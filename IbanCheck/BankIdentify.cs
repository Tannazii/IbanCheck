public class BankIdentify
{
    Dictionary<string, string> bins = new Dictionary<string, string>()
    {
        {"Markazi","010"},
        {"Sanat&Madan","011"},
        {"Mellat","012"},
        {"Refah","013"},
        {"Maskan","014"},
        {"Sepah","015"},
        {"Keshavarzi","016"},
        {"Melli","017"},
        {"Tejarat","018"},
        {"Saderat","019"},
        {"Tose'eSaderat","020"},
        {"PostBank","021"},
        {"Ta'avon","022"},
        {"Tose'e","051"},
        {"KarAfarin","053"},
        {"Parsian","054"},
        {"EghtesadNovin","055"},
        {"Saman","056"},
        {"Pasargad","057"},
        {"Sarmaye","058"},
        {"Sina","059"},
        {"MehrIran","060"},
        {"Shahr","061"},
        {"Ayandeh","062"},
        {"Ansareh","063"},
        {"Gardeshgari","064"},
        {"Hekmat","065"},
        {"Dey","066"},
        {"IranZamin","069"},
        {"Resalat","070"},
        {"Khavarmiyaneh","078"},
        {"Ghavamin","52"},
        {"Kosar","73"},
        {"Melal","75"},
        {"Shapark","93"},
        {"Venezoela","95"},

    };

    public string DetectBin(string iban)
    {
        string bank = " ";
        foreach (KeyValuePair<string, string> bin in bins)
        {
            if (iban.Substring(4, 3) == bin.Value)
            {
                bank = bin.Key;
            }
        }
        return bank;
    }
}

