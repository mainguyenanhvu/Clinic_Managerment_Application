using System;
using System.Collections.Generic;

namespace QuanLyPhongKham
{
    public class QueryHelper
    {
        private string defaultQueryTimeCondition = "select p.ID as 'ID', m.typeCheckup as 'Chuyên khoa', e.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar,m.dateCheckup,103) as 'Ngày khám',  p.note as 'Ghi chú', m.ID as 'idm', e.ID as 'ide' from (PatientInformation as p join MedicalExamination as m on (p.ID = m.idPatient)) left join CodeExamination as e on (p.ID = e.idPatient and m.typeCheckup = e.typeCheckup and year(m.dateCheckup) = -1;";
        Dictionary<string, string> queryTimeCondition = new Dictionary<string, string>
        {
            {"Day", "select p.ID as 'ID', m.typeCheckup as 'Chuyên khoa', e.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar,m.dateCheckup,103) as 'Ngày khám',  p.note as 'Ghi chú', m.ID as 'idm', e.ID as 'ide' from (PatientInformation as p join MedicalExamination as m on (p.ID = m.idPatient)) left join CodeExamination as e on (p.ID = e.idPatient and m.typeCheckup = e.typeCheckup and year(m.dateCheckup) = e.yearCheckup) where year(m.dateCheckup) = _YEAR_  and month(m.dateCheckup) = _MONTH_ and day(m.dateCheckup) = _DAY_;" },
            {"Month", "select p.ID as 'ID', m.typeCheckup as 'Chuyên khoa', e.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar,m.dateCheckup,103) as 'Ngày khám',  p.note as 'Ghi chú', m.ID as 'idm', e.ID as 'ide' from (PatientInformation as p join MedicalExamination as m on (p.ID = m.idPatient)) left join CodeExamination as e on (p.ID = e.idPatient and m.typeCheckup = e.typeCheckup and year(m.dateCheckup) = e.yearCheckup) where year(m.dateCheckup) = _YEAR_ and month(m.dateCheckup) = _MONTH_ ;" },
            {"Year", "select p.ID as 'ID', m.typeCheckup as 'Chuyên khoa', e.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar,m.dateCheckup,103) as 'Ngày khám',  p.note as 'Ghi chú', m.ID as 'idm', e.ID as 'ide' from (PatientInformation as p join MedicalExamination as m on (p.ID = m.idPatient)) left join CodeExamination as e on (p.ID = e.idPatient and m.typeCheckup = e.typeCheckup and year(m.dateCheckup) = e.yearCheckup) where year(m.dateCheckup) = _YEAR_ ;" }
        };
        public string create(string[] keywords, object Request)
        {
            if (keywords[0].Equals("select"))
            {
                if (keywords[1].Equals("time"))
                    return createQueryTimeCondition((TimeManagementHelper) Request);
            }
            else 
                if (keywords[0].Equals("delete"))
            {
                return defaultQueryTimeCondition;
            }
            return defaultQueryTimeCondition;
        }

        private string createQueryTimeCondition(TimeManagementHelper request)
        {
            switch (request.getStatus())
            {
                case "None":
                    return defaultQueryTimeCondition;
                case "Day":
                    return queryTimeCondition[request.getStatus()].Replace("_DAY_", request.date["Day"]).Replace("_MONTH_", request.date["Month"]).Replace("_YEAR_", request.date["Year"]);
                case "Month":
                    return queryTimeCondition[request.getStatus()].Replace("_MONTH_", request.date["Month"]).Replace("_YEAR_", request.date["Year"]);
                case "Year":
                    return queryTimeCondition[request.getStatus()].Replace("_YEAR_", request.date["Year"]);
                default:
                    return defaultQueryTimeCondition;
            }
        }
    }
}