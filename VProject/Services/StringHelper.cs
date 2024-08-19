using System.Text.RegularExpressions;

namespace VProject.Services;

public static class StringHelper{
    private static Regex rexNum=new(@"[-+]?\d*\.?\d+([eE][-+]?\d+)?");

    public static bool CheckNumber(string s,out string num){
        if(s is null or ""){
            num="";
            return false;
        }
        Match m=rexNum.Match(s);
        num=m.Value;
        return m.Success;
    }
}