using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StoreManagement.Models;
using StoreManagement.Models.Entities;
using StoreManagement.Models.ViewModels;

namespace StoreManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly StoreDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(StoreDbContext context, IWebHostEnvironment hostEnvironment,
            UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index() => View(_userManager.Users.ToList());

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(ModelForCreate model)
        {
            if (ModelState.IsValid)
            {
                Address address = new Address()
                {
                    ProvinceId = model.Province,
                    DistrictId = model.District,
                    WardId = model.Ward,
                    HouseNum = model.HouseNumber
                };
                _context.Add(address);
                await _context.SaveChangesAsync();

                ApplicationUser User = new ApplicationUser()
                {
                    Avatar = UploadedFile(model.iformfile_path),
                    FullName = model.FullName,
                    PhoneNumber = model.PhoneNum,
                    Email = model.Email,
                    UserName = model.Email,
                    AddressId = address.Id
                };
                var result = await _userManager.CreateAsync(User, model.Password);
                address.UserId = User.Id;
                await _context.SaveChangesAsync();

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(User, false);
                    return RedirectToAction("Index", "Account");
                }
                else
                    foreach (var item in result.Errors)
                        ModelState.AddModelError("", item.Description);
            }
            return View();
        }

        private string UploadedFile(IFormFile iformfile_path)
        {
            string uniqueFileName = null;

            if (iformfile_path != null)
            {
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images/UserImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + iformfile_path.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    iformfile_path.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = "") =>
            View(new LoginViewModel { ReturnUrl = returnUrl });

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                        return Redirect(model.ReturnUrl);
                    else
                        return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Invalid account or password");

            return View(model);
        }

        public JsonResult GetDistrictById(int id) =>
            Json(new SelectList(_context.District.Where(x => x.ProvinceId == id).ToList(), "Id", "Name"));

        public JsonResult GetWardById(int id) =>
             Json(new SelectList(_context.Ward.Where(x => x.DistrictId == id).ToList(), "Id", "Name"));

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var User = _userManager.FindByIdAsync(id).Result;
            var address = _context.Addresses.ToList().Find(el => el.Id == User.AddressId);

            ModelForEdit model = new ModelForEdit()
            {
                Email = User.Email,
                FullName = User.FullName,
                Id = User.Id,
                Address = address,
                Avatar_Path = User.Avatar,
                PhoneNum = User.PhoneNumber
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ModelForEdit UserModel)
        {
            Address address = _context.Addresses.ToList().Find(x => x.Id == UserModel.Address.Id);

            address.ProvinceId = UserModel.Address.ProvinceId;
            address.DistrictId = UserModel.Address.DistrictId;
            address.WardId = UserModel.Address.WardId;
            address.HouseNum = UserModel.Address.HouseNum;

            _context.Update(address);
            await _context.SaveChangesAsync();

            var FindUser = _userManager.FindByIdAsync(UserModel.Id).Result;

            FindUser.Email = UserModel.Email;
            FindUser.FullName = UserModel.FullName;
            FindUser.PhoneNumber = UserModel.PhoneNum;
            FindUser.Address = address;
            FindUser.Avatar = UserModel.Avatar_Path;

            if (UserModel.iformfile_path != null)
            {
                FindUser.Avatar = UploadedFile(UserModel.iformfile_path);

                if (!string.IsNullOrEmpty(UserModel.Avatar_Path))
                {
                    string DelPath = Path.Combine(_hostEnvironment.WebRootPath, "images", UserModel.Avatar_Path);
                    System.IO.File.Delete(DelPath);
                }
            }
            await _userManager.UpdateAsync(FindUser);

            return RedirectToAction("Index", "Account");
        }

        [Route("/Account/Delete/{id}")]
        public IActionResult Delete(string id)
        {
            var deleteResult = false;
            var existUser = Task.Run(async () => await _userManager.FindByIdAsync(id)).Result;

            if (existUser == null)
                return Json(new { deleteResult });

            var address = _context.Addresses.FirstOrDefault(el => el.Id == existUser.AddressId);

            _context.Remove(address);
            Task.Run(async () => await _context.SaveChangesAsync());

            if (!string.IsNullOrEmpty(existUser.Avatar))
            {
                string DelPath = Path.Combine(_hostEnvironment.WebRootPath, "Images/UserImages", existUser.Avatar);
                System.IO.File.Delete(DelPath);
            }

            var identityResult = Task.Run(async () => await _userManager.DeleteAsync(existUser)).Result;
            deleteResult = identityResult.Succeeded;

            return Json(new { deleteResult });
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
