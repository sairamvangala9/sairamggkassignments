using System;

namespace FloatUserDefined
{
    public class FloatUser
    {
        private const int MaxMantissaLength=32;
        private string mantissa=string.Empty;
        private int sign=1;
        private int exp=0;
        private string debugString=string.Empty;
        public FloatUser()
        {
            mantissa=string.Empty;
            exp=0;
            sign=0;
        }
        /// <summary>
        /// parameterized constructor which takes float number in
        /// form of string and converts the string into mantissa,
        /// exponent and sign, store in the attributes of objects 
        /// of FloatUser class
        /// </summary>
        /// <param name="rawString"></param>
        public FloatUser(string rawString)
        {
            mantissa=string.Empty;
            exp=0;
            if(rawString[0]=='-')
            {
                sign=0;
                rawString=rawString.Substring(1);
            }
            float floatVal = Convert.ToSingle(rawString);
            //binary value of integral part
            string binaryString = Convert.ToString((int)floatVal, 2);
            //for values which have non-zero integral value
            //Console.WriteLine(binaryString);
            
            if((int)floatVal>0)
            {
                floatVal=floatVal-(int)floatVal;
                int dotPosition=binaryString.Length;
                binaryString=binaryString+".";
                for(int i=dotPosition;i<=MaxMantissaLength;i++)
                {
                    floatVal=floatVal*2;
                    binaryString=binaryString+Convert.ToString((int)floatVal);
                    floatVal=floatVal-(int)floatVal;
                }
                //Console.WriteLine(binaryString.Substring(dotPosition+1));
                exp=-(binaryString.Substring(dotPosition+1)).Length;
                binaryString=binaryString.Substring(0,dotPosition)+binaryString.Substring(dotPosition+1);
                binaryString=binaryString.Substring(0,binaryString.Length-1);
            }
            //for values with zero integral values
            else
            {
                floatVal=floatVal-(int)floatVal;
                binaryString=binaryString+".";
                while((int)floatVal!=1)
                {
                    floatVal=floatVal*2;
                    exp--;
                }
                for(int i=0;i<MaxMantissaLength;i++)
                {
                    exp--;
                    binaryString=binaryString+Convert.ToString((int)floatVal);
                    floatVal=floatVal-(int)floatVal;
                    floatVal=floatVal*2;
                }
                binaryString=binaryString.Substring(2);
            }
            debugString=binaryString+" "+sign+" "+exp;
            //Console.WriteLine(binaryString+" "+sign+" "+exp);
            mantissa=binaryString;
        }
        /// <summary>
        /// function to make two's complement to mantissa of
        /// the FloatUser object that is used to invoke
        /// this function
        /// </summary>
        private void twosComplement()
        {
            string tempStr=string.Empty;
            int i=mantissa.Length-1;
            while(mantissa[i]=='0'&&i<mantissa.Length)
            {
                tempStr="0"+tempStr;
                i--;
            }
            if(mantissa[i]=='1')
            {
                tempStr="1"+tempStr;
                i--;
                for(;i>=0;i--)
                {
                    if(mantissa[i]=='1')
                    {	
                        tempStr="0"+tempStr;
                    }
                    else
                    {
                        tempStr="1"+tempStr;
                    }
                }
            }
            mantissa=tempStr;
        }
        /// <summary>
        /// function to perform addition of given two float numbers as
        /// parameters in the form of FloatUser class objects
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public FloatUser floatAddition(FloatUser input1,FloatUser input2)
        {
            //addition is done so that object 'input1' has larger value than 'input2',so swapping is done.
            FloatUser result=new FloatUser();
            if(input1.sign==0&&input2.sign==1)
            {
                input1.twosComplement();
            }
            if(input2.sign==0&&input1.sign==1)
            {
                input2.twosComplement();
            }
            if(input1.sign==input2.sign)
            {
                result.sign=input1.sign;
            }
            if(input1.exp<input2.exp)
            {
                FloatUser temp;
                temp=input1;
                input1=input2;
                input2=temp;
            }
            for(int i=0;i<(input1.exp-input2.exp);i++)
            {
                input1.mantissa="0"+input2.mantissa;	
            }	
            int carry=0;
            input2.mantissa=input2.mantissa.Substring(0,MaxMantissaLength);
            result.exp=input2.exp=input1.exp;
            string floatAdd=string.Empty;
            for(int i=MaxMantissaLength-1;i>=0;i--)
            {
                result.mantissa=(((int)input1.mantissa[i]+	(int)input2.mantissa[i]+carry - 96) % 2).ToString()+result.mantissa;
                carry = (int)(((int)input1.mantissa[i] + (int)input2.mantissa[i] + carry - 96) / 2);
            }
            if(carry==1&&input1.sign==input2.sign)
            {
                result.mantissa="1"+result.mantissa.Substring(0,result.mantissa.Length-1);
                result.exp++;
            }
            if(input1.sign!=input2.sign)
            {
                if(carry==1)
                {
                    result.sign=1;
                }
                else
                {
                    result.sign=0;
                    result.twosComplement();
                }
            }
            return result;
        }
        /// <summary>
        /// function to display the float number by using
        /// mantissa of 32bit(MaxMantissaLength given in the code),
        /// exponent and sign
        /// </summary>
        public void displayIEEE()
        {
            Console.WriteLine("\n"+mantissa+" "+sign+" "+exp);
        }
    }
}