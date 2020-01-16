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

        private string defaultQueryAttributeCondition = "select p.ID as 'ID', m.typeCheckup as 'Chuyên khoa', e.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar, m.dateCheckup, 103) as 'Ngày khám',  p.note as 'Ghi chú', m.ID as 'idm', e.ID as 'ide' from(PatientInformation as p join MedicalExamination as m on(p.ID = m.idPatient)) left join CodeExamination as e on(p.ID = e.idPatient and m.typeCheckup = e.typeCheckup and year(m.dateCheckup) = e.yearCheckup) where year(m.dateCheckup) = -1; ";
        Dictionary<string, string> queryAttributeCondition = new Dictionary<string, string>()
        {
            {"name", "select p.ID as 'ID', m.typeCheckup as 'Chuyên khoa', e.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar, m.dateCheckup, 103) as 'Ngày khám',  p.note as 'Ghi chú', m.ID as 'idm', e.ID as 'ide' from(PatientInformation as p join MedicalExamination as m on(p.ID = m.idPatient)) left join CodeExamination as e on(p.ID = e.idPatient and m.typeCheckup = e.typeCheckup and year(m.dateCheckup) = e.yearCheckup) where p.name like '%_NAME_%' collate Latin1_General_CI_AI ;" },
            {"address",  "select p.ID as 'ID', m.typeCheckup as 'Chuyên khoa', e.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar, m.dateCheckup, 103) as 'Ngày khám',  p.note as 'Ghi chú', m.ID as 'idm', e.ID as 'ide' from(PatientInformation as p join MedicalExamination as m on(p.ID = m.idPatient)) left join CodeExamination as e on(p.ID = e.idPatient and m.typeCheckup = e.typeCheckup and year(m.dateCheckup) = e.yearCheckup) where p.address1 like '%_ADDRESS_%' collate Latin1_General_CI_AI ;"},
            {"phonenumber",  "select p.ID as 'ID', m.typeCheckup as 'Chuyên khoa', e.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar, m.dateCheckup, 103) as 'Ngày khám',  p.note as 'Ghi chú', m.ID as 'idm', e.ID as 'ide' from(PatientInformation as p join MedicalExamination as m on(p.ID = m.idPatient)) left join CodeExamination as e on(p.ID = e.idPatient and m.typeCheckup = e.typeCheckup and year(m.dateCheckup) = e.yearCheckup) where p.phonenumber like '%_PHONENUMBER_%' collate Latin1_General_CI_AI ;"},
            {"profilecode",  "select p.ID as 'ID', m.typeCheckup as 'Chuyên khoa', e.profileCode as 'Mã hồ sơ', p.name as 'Họ và tên', p.birthyear as 'Năm sinh', p.gender as 'Giới tính', p.address1 as 'Địa chỉ', p.phonenumber as 'Số điện thoại', convert(varchar, m.dateCheckup, 103) as 'Ngày khám',  p.note as 'Ghi chú', m.ID as 'idm', e.ID as 'ide' from(PatientInformation as p join MedicalExamination as m on(p.ID = m.idPatient)) left join CodeExamination as e on(p.ID = e.idPatient and m.typeCheckup = e.typeCheckup and year(m.dateCheckup) = e.yearCheckup) where e.profileCode like '%_PROFILECODE_%' collate Latin1_General_CI_AI ;"},
            {"medical", "select convert(varchar,m.dateCheckup,103) as 'Ngày khám', m.typeCheckup as 'Chuyên khoa', e.profileCode as 'Mã hồ sơ' from MedicalExamination as m left join CodeExamination as e on (m.idPatient = e.idPatient and m.typeCheckup = e.typeCheckup and year(m.dateCheckup) = e.yearCheckup) where m.idPatient = _IDM_;" }
        };

        Dictionary<string, string> queryDelete = new Dictionary<string, string>()
        {
            {"one", "delete from MedicalExamination where ID = _IDM_; delete  from PatientInformation  where ID not in (select idPatient from MedicalExamination); delete from CodeExamination where idPatient not in (select ID from PatientInformation) or (typeCheckup not in (select typeCheckup from MedicalExamination where idPatient = _ID_ and year(dateCheckup) = _YEAR_) and idPatient = _ID_ and yearCheckup = _YEAR_); delete  from MedicalExamination  where idPatient not in (select ID from PatientInformation);" },
            {"Day", "delete from MedicalExamination where year(dateCheckup) = _YEAR_ and month(dateCheckup) = _MONTH_ and day(dateCheckup) = _DAY_; delete from PatientInformation  where ID not in (select idPatient from MedicalExamination); delete from CodeExamination where yearCheckup = _YEAR_ or idPatient not in (select ID from PatientInformation);" },
            {"Month", "delete from MedicalExamination where year(dateCheckup) = _YEAR_ and month(dateCheckup) = _MONTH_; delete from PatientInformation  where ID not in (select idPatient from MedicalExamination); delete from CodeExamination where yearCheckup = _YEAR_ or idPatient not in (select ID from PatientInformation);" },
            {"Year", "delete from MedicalExamination where year(dateCheckup) = _YEAR_; delete from PatientInformation  where ID not in (select idPatient from MedicalExamination); delete from CodeExamination where yearCheckup = _YEAR_ or idPatient not in (select ID from PatientInformation);" }
        };


        public string create(string[] keywords, object Request)
        {
            if (keywords[0].Equals("select"))
            {
                return createSelectQuery(keywords, Request);
            }
            else
                if (keywords[0].Equals("delete"))
            {
                return createDeleteQuery(keywords, Request);

            }
            return createdefaultQuery("create") ;
        }

        private string createDeleteQuery(string[] keywords, object Request)
        {
            if (keywords[1].Equals("one"))
                return createQueryDeleteOne((string[])Request);
            else
                    if (keywords[1].Equals("all"))
                return creaQueryDeleteAll((TimeManagementHelper) Request);
            return createdefaultQuery("delete");
        }

        private string createSelectQuery(string[] keywords, object Request)
        {
            if (keywords[1].Equals("time"))
                return createQueryTimeCondition((TimeManagementHelper)Request);
            else
               if (keywords[1].Equals("attribute"))
                return createQueryAttributeCondition((StringSearch)Request);
            if (keywords[1].Equals("medical"))
                return createQueryMedicalCondition((string[])Request);
            return createdefaultQuery("time");
        }

        private string createQueryMedicalCondition(string[] request)
        {
            return queryAttributeCondition["medical"].Replace("_IDM_",request[0]);
        }

        private string creaQueryDeleteAll(TimeManagementHelper request)
        {
            switch (request.getStatus())
            {
                case "Day":
                    return queryDelete[request.getStatus()].Replace("_DAY_", request.date["Day"]).Replace("_MONTH_", request.date["Month"]).Replace("_YEAR_", request.date["Year"]);
                case "Month":
                    return queryDelete[request.getStatus()].Replace("_MONTH_", request.date["Month"]).Replace("_YEAR_", request.date["Year"]);
                case "Year":
                    return queryDelete[request.getStatus()].Replace("_YEAR_", request.date["Year"]);
                default:
                    return createdefaultQuery("delete");
            }
        }

        private string createQueryDeleteOne(string[] request)
        {
            return queryDelete["one"].Replace("_IDM_", request[0]).Replace("_ID_",request[1]).Replace("_YEAR_",request[2]);
        }

        private string createQueryAttributeCondition(StringSearch request)
        {
            switch (request.getKeywords()[0])
            {
                case "name":
                    return queryAttributeCondition[request.getKeywords()[0]].Replace("_NAME_", request.getSearchString());
                case "address":
                    return queryAttributeCondition[request.getKeywords()[0]].Replace("_ADDRESS_", request.getSearchString());
                case "phonenumber":
                    return queryAttributeCondition[request.getKeywords()[0]].Replace("_PHONENUMBER_", request.getSearchString());
                case "profilecode":
                    return queryAttributeCondition[request.getKeywords()[0]].Replace("_PROFILECODE_", request.getSearchString());
                default:
                    return createdefaultQuery("attribute");
            }
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
                    //return defaultQueryTimeCondition;
                    return createdefaultQuery("time");
            }
        }

        private string createdefaultQuery(string type)
        {
            switch (type)
            {
                case "time":
                    return defaultQueryTimeCondition;
                case "attribute":
                    return defaultQueryAttributeCondition;
                case "delete":
                    return ";";
                case "create":
                    return ";";
                default:
                    return ";";
            }
        }
    }
}