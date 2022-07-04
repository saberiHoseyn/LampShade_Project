using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework.Application
{
    public class ApplicationMessages
    {
        public static string DuplicatedRecord { get; private set; } = "امکان ثبت رکورد تکراری وجود ندارد٬ لطفا مجددا تکلاش کنید.";
        public static string RecordNotFound { get; private set; } = "رکوردی با اطلاعات درخواستی یافت نشد٬ لطفا مجددا تلاش فرمایید.";
    }
}
