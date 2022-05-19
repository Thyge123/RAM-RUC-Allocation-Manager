using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RAM___RUC_Allocation_Manager.MockData;
using RAM___RUC_Allocation_Manager.Models;
using RAM___RUC_Allocation_Manager.Models.WorkAssigments;
using RAM___RUC_Allocation_Manager.Services;

namespace RAM___RUC_Allocation_Manager.Pages.LeaderLandingPage
{
    public class LeaderLandingPageModel : PageModel
    {
        #region Fields
        private UserService userService;
        #endregion

        #region Properties
        public List<User> Users { get; set; }

        [BindProperty]
        public Models.User User { get; set; }

        [BindProperty]
        public Models.Employee Employee { get; set; }

        public bool IsLeader { get; set; }
        #endregion

        public LeaderLandingPageModel(UserService userService)
        {
            this.userService = userService;
        }
        
        public IActionResult OnGet()
        {
            IsLeader = false;
            Users = userService.GetUsers();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            userService.CreateUser(User);
            return RedirectToPage("/LeaderLandingPage/LeaderLandingPage");
        }

        //public void OnPostCheckType()
        //{
        //    if (User.Type == User.UserType.Employee)
        //    {
        //        IsLeader = false;
        //    }

        //    else
        //    {
        //        IsLeader = true;
        //    }
            
        //}
    }
}
