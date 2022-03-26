using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeSql.DataAnnotations;
using Serilog;

namespace ExcelAddInVSTOCS.Storage
{
    public class UserHabit
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public string WorkbookFullName { get; set; }

        public bool VisiableTaskPane { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public void Save(string wfn)
        {
            DemoHub.FSQL.Update<UserHabit>()
                .Where(uh => uh.WorkbookFullName == wfn)
                .SetSource(this)
                .ExecuteAffrows();
            Log.Information("保存用户习惯：{0}", this);
        }

        public static UserHabit Load(string wfn)
        {
            UserHabit habit = DemoHub.FSQL.Select<UserHabit>()
                .Where(ub => ub.WorkbookFullName == wfn)
                .First();
            if (habit is null)
            {
                habit = new UserHabit()
                {
                    WorkbookFullName = wfn,
                    VisiableTaskPane = false,
                    CreateAt = DateTime.Now,
                    UpdateAt = null,
                };
                DemoHub.FSQL.Insert(habit).ExecuteAffrows();
                Log.Information($"首条习惯数据 {habit}");

            }
            return habit;
        }
    }
}
