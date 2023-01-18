using System;
namespace basics {
    public class TypeCastConvertParseExplainer {
        public static void Main(string[] args) {
            //1. implicit conversions: small memory into big container
            int i = 10;
            float f = i; //this is valid: look for allowed implicit conversions

            // 2. explicit conversions: look for allowed explicit conversions
            float f2 = 500.234f;
            int i2 = (int)f2;

            //3. parsing -> usually for anything that needs conversion from or to a string
            string year = "1999";
            int myyear = Convert.ToInt32(year);
            
            string somedecimal = Convert.ToString(f2);


        }
    }
}