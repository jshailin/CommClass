using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HailinLib
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：8/22 周二 下午 04:28:56 
    /// 修改时间：8/22 周二 下午 04:28:56 
    /// 版权：2017-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// CnCalendar说明：农历信息类 
    /// 本代码版权归海陵所有 
    /// 唯一标识：1a204484-64ba-4c94-8c7c-74c8b5f9d2c5 
    /// </summary> 
    public class CnCalendar
    {
        //当前日期（公历）
        private DateTime myDate;
        //甲子中的年份
        private int sexagenaryYear;
        //年份天干
        private int celestialStem;
        //年份地支
        private int terrestrialBranch;
        //农历月份
        private int cnMonth;
        //农历闰月
        private int cnLeapMonth;
        //农历日子
        private int cnDay;

        //年份用,天干与地支数组
        private static string[] arrCelestialStem = { "", "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸" };

        private static string[] arrTerrestrialBranch = { "", "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥" };
        //农历月份名称
        private static string[] arrMonthName = { "", "正月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "冬月", "腊月" };
        //农历日子
        private static string[] arrDayName = { "", "初一", "初二", "初三", "初四", "初五", "初六", "初七", "初八", "初九", "初十", "十一", "十二", "十三", "十四", "十五", "十六", "十七", "十八", "十九", "二十", "廿一", "廿二", "廿三", "廿四", "廿五", "廿六", "廿七", "廿八", "廿九", "三十" };
        //属相
        private static string[] arrAnimalName = { "猪", "鼠", "牛", "虎", "兔", "龙", "蛇", "马", "羊", "猴", "鸡", "狗" };

        //构造函数,根据日期算农历信息
        public CnCalendar(DateTime date)
        {
            myDate = date;
            ChineseLunisolarCalendar caleCn=new ChineseLunisolarCalendar();
            //计算农历年份
            sexagenaryYear = caleCn.GetSexagenaryYear(myDate);
            //计算天干
            celestialStem = caleCn.GetCelestialStem(sexagenaryYear);
            //计算地支
            terrestrialBranch = caleCn.GetTerrestrialBranch(sexagenaryYear);
            //计算农历月份
            cnMonth = caleCn.GetMonth(myDate);
            //农历闰月
            if (myDate.Month<3&&cnMonth>9)
            {
                cnLeapMonth = caleCn.GetLeapMonth(myDate.Year - 1);
            }
            else
            {
                cnLeapMonth = caleCn.GetLeapMonth(myDate.Year);
            }
            //计算日子
            cnDay = caleCn.GetDayOfMonth(myDate);
        }

    }
}
