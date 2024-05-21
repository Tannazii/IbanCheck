
public class IbanValidator
{
    private bool CheckLength(string iban)
    {
        bool result = true;

        if (iban.Length != 26)
            return false;

        return result;
    }

    private bool CheckSum(string iban)
    {
        bool result = true;
        iban = iban + "1827" + iban.Substring(2, 2);
        decimal iban_num = decimal.Parse(iban.Remove(0, 4));

        if (iban_num % 97 == 1)
        {
            return true;
        }
        else
        {
            return false;
        }

        return result;
    }

    public decimal BBAN(string iban)
    {
        decimal bban = decimal.Parse(iban.Substring(8, 18));

        return bban;
    }


    public bool Validate (Iban iban)
    {
        bool result = false;
        if(CheckLength(iban.IbanNumber) == true && CheckSum(iban.IbanNumber) == true)
        {
            result = true;
        }
        return result;
    }












}

