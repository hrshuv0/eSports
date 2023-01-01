using System.Text.RegularExpressions;
using Core.Base;

namespace Framework.Utility;

public class CommonHelper
{
    public static string GetStatusText(int status)
    {
        var statusText = "-";

        if (status == EntityStatus.Active)
            statusText = "Active";
        else if (status == EntityStatus.Inactive)
            statusText = "Inactive";
        else if (status == EntityStatus.Deleted)
            statusText = "Deleted";

        return statusText;
    }

    public static string GetDisplayString(int? value, string str = "-")
    {
        return value == null ? str : value.Value.ToString();
    }

    public static string GetDisplayString(DateTime? dateTime, string format = "dd-MM-yyyy", string str = "-")
    {
        return dateTime == null ? str : dateTime.Value.ToString(format);
    }

    public static string GetDisplayString(bool? value, string str = "-")
    {
        return value == null ? str : (value.Value == true) ? "Yes" : "No";
    }

    public static string ValidateMobile(string mobileNumber, string regularExpression = @"^(?:\+?88)?0?1[1-9]\d{8}$",
        bool isThrowException = true)
    {
        if (string.IsNullOrWhiteSpace(mobileNumber) == false)
        {
            switch (mobileNumber.Trim().Length)
            {
                case 10:
                    mobileNumber = "880" + mobileNumber;
                    break;
                case 11:
                    mobileNumber = "88" + mobileNumber;
                    break;
            }
        }

        var result = Regex.Matches(mobileNumber, regularExpression);
        if (result.Any() == false || result.Count == 0)
            mobileNumber = isThrowException ? throw new Exception("Invalid mobile number"):"";

        return mobileNumber;
    }
}