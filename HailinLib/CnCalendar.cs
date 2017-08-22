using System;
using System.Globalization;

namespace HailinLib
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：8/22 周二 下午 04:28:56 
    /// 修改时间：8/22 周二 下午 08:00:00 
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
        //甲子中的年份
        private readonly int _sexagenaryYear;
        //年份天干
        private readonly int _celestialStem;
        //年份地支
        private readonly int _terrestrialBranch;
        //农历月份
        private readonly int _cnMonth;
        //农历闰月
        private readonly int _cnLeapMonth;
        //农历日子
        private readonly int _cnDay;

        //年份用,天干与地支数组
        private static readonly string[] ArrCelestialStem = { "", "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸" };

        private static readonly string[] ArrTerrestrialBranch = { "", "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥" };
        //农历月份名称
        private static readonly string[] ArrMonthName = { "", "正月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "冬月", "腊月" };
        //农历日子
        private static readonly string[] ArrDayName = { "", "初一", "初二", "初三", "初四", "初五", "初六", "初七", "初八", "初九", "初十", "十一", "十二", "十三", "十四", "十五", "十六", "十七", "十八", "十九", "二十", "廿一", "廿二", "廿三", "廿四", "廿五", "廿六", "廿七", "廿八", "廿九", "三十" };
        //属相
        private static readonly string[] ArrAnimalName = { "猪", "鼠", "牛", "虎", "兔", "龙", "蛇", "马", "羊", "猴", "鸡", "狗" };

        //构造函数,根据日期算农历信息
        public CnCalendar(DateTime date)
        {
            var myDate = date;
            ChineseLunisolarCalendar caleCn = new ChineseLunisolarCalendar();
            //计算农历年份
            _sexagenaryYear = caleCn.GetSexagenaryYear(myDate);
            //计算天干
            _celestialStem = caleCn.GetCelestialStem(_sexagenaryYear);
            //计算地支
            _terrestrialBranch = caleCn.GetTerrestrialBranch(_sexagenaryYear);
            //计算农历月份
            _cnMonth = caleCn.GetMonth(myDate);
            //农历闰月
            if (myDate.Month < 3 && _cnMonth > 9)
            {
                _cnLeapMonth = caleCn.GetLeapMonth(myDate.Year - 1);
            }
            else
            {
                _cnLeapMonth = caleCn.GetLeapMonth(myDate.Year);
            }
            //计算日子
            _cnDay = caleCn.GetDayOfMonth(myDate);
        }

        //显示年份名称
        public string GetYearName()
        {
            return ArrCelestialStem[_celestialStem] + ArrTerrestrialBranch[_terrestrialBranch] + "年";
        }

        //显示月份名称
        public string GetMonthName()
        {
            //显示月份，考虑闰月情况
            if (_cnLeapMonth == 0)
            {
                return ArrMonthName[_cnMonth];
            }
            else
            {
                if (_cnMonth < _cnLeapMonth)
                {
                    return ArrMonthName[_cnMonth];
                }
                else if (_cnMonth == _cnLeapMonth)
                {
                    return "闰" + ArrMonthName[_cnMonth - 1];
                }
                else
                {
                    return ArrMonthName[_cnMonth - 1];
                }
            }
        }

        //显示日子名称
        public string GetDayName()
        {
            return ArrDayName[_cnDay];
        }

        //显示属相
        public string GetAnimalName()
        {
            return ArrAnimalName[_sexagenaryYear % 12];
        }
    }
}
