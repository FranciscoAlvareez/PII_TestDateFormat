namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    public static string ChangeFormat(string date)
    {
        if(Separaciones(date) && EspaciosLibres(date) && ValoresCorrectos(date))
        {
            string[] parte=date.Split("/");
            return parte[2]+"-"+parte[1]+"-"+parte[0];
        }
        else
        {
            return null;
        }
        
        //return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
    }
    public static bool Separaciones(string date){
        return date.Split("/").Length==3 && (date.IndexOf("/")==2 ||  date.IndexOf("/")==1) && (date.LastIndexOf("/")>=4 && date.LastIndexOf("/")<=6);
    }
    public static bool EspaciosLibres(string date){
        string[] parte=date.Split("/");
        return parte[0].Trim() !="" && parte[1].Trim() !=""  && parte[2].Trim() !="" ;
    }

    public static int cantidadDias(int mes,int anio)
    {
        if(mes==4 || mes==6 || mes==9 || mes==11)
        {
            return 30;
        }
        else
            if(mes==2)
            {
                if((anio%4==0 && anio%100==0)|| anio%400==0)
                {
                    return 29;
                }
                else{
                    return 28;
                }
            }
            else{
                return 31;
            }
    }

    public static bool ValoresCorrectos(string date){
        string[] parte=date.Split("/");
        try{
            int dia=Convert.ToInt32(parte[0]);
            int mes=Convert.ToInt32(parte[1]);
            int anio=Convert.ToInt32(parte[2]);

            return (1<=dia && dia<=cantidadDias(mes,anio)) &&(1<=mes && mes<=12)  ; 
        }
        catch(Exception ex)
        {
            return false;
        }


    }
}
