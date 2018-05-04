namespace PlanApp1.Helpers
{
    using System;
    using System.Text.RegularExpressions;


    //aqui se creo una expresion regular para validar el email

    public static class RegexUtilities
    {
        /*  tiene un solo metodo y lo que hace es validar que si sea un email */
        #region ValidacionEmail

        public static bool IsValidEmail(string email)
        {
            var expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}