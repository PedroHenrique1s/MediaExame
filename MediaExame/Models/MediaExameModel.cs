namespace MediaExame.Models;
using System.ComponentModel.DataAnnotations;

public class MediaExameModel
{
    [Range(0,10, ErrorMessage = "A nota deve ser 0 a 10")]
    public double intermediaria {get; set;}
    [Range(0,10, ErrorMessage = "A nota deve ser 0 a 10")]
    public double semestral {get; set;}
    [Range(0,10, ErrorMessage = "A nota deve ser 0 a 10")]
    public double trabalho {get; set;}
    
}