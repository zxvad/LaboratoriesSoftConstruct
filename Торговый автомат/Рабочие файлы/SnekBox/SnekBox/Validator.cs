namespace SnekBox
{
    public class Validator:IValidator
    {
        public int bond { get; set; }

        public int GetMoney(int input)
        {
            return bond; 
        }

        public bool ValidateMoney(int input)
        {
            bool real = false;
            
            return real;
        }
    }
}