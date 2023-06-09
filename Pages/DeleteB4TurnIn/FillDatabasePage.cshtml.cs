using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RAM___RUC_Allocation_Manager.MockData;
using RAM___RUC_Allocation_Manager.Models;
using RAM___RUC_Allocation_Manager.Models.DbConnections;
using RAM___RUC_Allocation_Manager.Models.WorkAssigments;
using RAM___RUC_Allocation_Manager.Models.WorkAssigments.Committee;
using RAM___RUC_Allocation_Manager.Services;

namespace RAM___RUC_Allocation_Manager.Pages.DeleteB4TurnIn
{
    public class FillDatabasePageModel : PageModel
    {
        public FalkesMockdata FalkesMockdata { get; set; }
        private DbService<Employee> employeeDbService;
        private DbService<Leader> leaderDbService;
        private DbService<Programme> programmeDbService;
        private DbService<CustomCommittee> customecommitteeDbService;
        private DbService<PromotionCommitteeTask> promotionDbService;
        private DbService<HiringCommittee> hiringDbService;
        private DbService<Course> courseDbService;
        private DbService<GroupFacilitationTask> groupFacilitationTaskDbService;
        private DbService<PhdTasks> phdTaskDbService;
        private DbService<Group> groupDbService;
        private DbService<Redemption> redemptionDbService;
        private DbService<EmployeeCourse> employeeCourseDbService;
        private DbService<EmployeeCustomCommittee> eccDbService;
        private DbService<EmployeeGroup> egDbService;
        private DbService<EmployeeHiringCommittee> ehcDbService;
        private DbService<EmployeeProgramme> epDbService;
        private DbService<LeaderProgramme> lpDbService;

        public FillDatabasePageModel(DbService<Employee> employeeDbService, DbService<Leader> leaderDbService, DbService<Programme> programmeDbService, DbService<CustomCommittee> customecommitteeDbService, DbService<PromotionCommitteeTask> promotionDbService, DbService<HiringCommittee> hiringDbService, DbService<Course> courseDbService, DbService<GroupFacilitationTask> groupFacilitationTaskDbService, DbService<PhdTasks> phdTaskDbService, DbService<Group> groupDbService, DbService<Redemption> redemptionDbService, DbService<EmployeeCourse> employeeCourseDbService, DbService<EmployeeCustomCommittee> eccDbService, DbService<EmployeeGroup> egDbService, DbService<EmployeeHiringCommittee> ehcDbService, DbService<EmployeeProgramme> epDbService, DbService<LeaderProgramme> lpDbService)
        {
            this.employeeDbService = employeeDbService;
            this.leaderDbService = leaderDbService;
            this.programmeDbService = programmeDbService;
            this.customecommitteeDbService = customecommitteeDbService;
            this.promotionDbService = promotionDbService;
            this.hiringDbService = hiringDbService;
            this.courseDbService = courseDbService;
            this.groupFacilitationTaskDbService = groupFacilitationTaskDbService;
            this.phdTaskDbService = phdTaskDbService;
            this.groupDbService = groupDbService;
            this.redemptionDbService = redemptionDbService;
            this.employeeCourseDbService = employeeCourseDbService;
            this.eccDbService = eccDbService;
            this.egDbService = egDbService;
            this.ehcDbService = ehcDbService;
            this.epDbService = epDbService;
            this.lpDbService = lpDbService;
        }
        public void OnGet()
        {
        }

        public async void OnPostAsync()
        {
            FalkesMockdata = new FalkesMockdata();
            foreach (var o in FalkesMockdata.GetEmployees())
            {
                await employeeDbService.AddObjectAsync(o);
            }
            //Hvis du f�r en error her, ved automatisk oprettelse af data. Ignorer dette, og genstart programmet.
            foreach (var o in FalkesMockdata.GetLeaders())
            {
                await leaderDbService.AddObjectAsync(o);
            }
            //foreach (var o in FalkesMockdata.GetSynopses())
            //{     
            //    await synopsisDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetCourses())
            //{
            //    await courseDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetPortfolios())
            //{
            //    await portfolioDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetAssistantProfessorSupervisions())
            //{
            //    await assistentProSupervisionDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetCustomCommittees())
            //{
            //    await customecommitteeDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetProgrammes())
            //{
            //    await programmeDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetPromotionCommitteeTasks())
            //{
            //    await promotionDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetHiringCommittees())
            //{
            //    await hiringDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetPhdCommittees())
            //{
            //    await phdCommitteeDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetGroupFacilitationTasks())
            //{
            //    await groupFacilitationTaskDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetPhdTasks())
            //{
            //    await phdTaskDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetGroups())
            //{
            //    await groupDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetRedemptions())
            //{
            //    await redemptionDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetEmployeeCourses())
            //{
            //    await employeeCourseDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetEmployeeCustomCommittees())
            //{
            //    await eccDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetEmployeeGroups())
            //{
            //    await egDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetEmployeeHiringCommittees())
            //{
            //    await ehcDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetEmployeeProgrammes())
            //{
            //    await epDbService.AddObjectAsync(o);
            //}
            //foreach (var o in FalkesMockdata.GetLeaderProgrammes())
            //{
            //    await lpDbService.AddObjectAsync(o);
            //}
        }
    }
}
