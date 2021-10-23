using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Lab03BradyValentine;

public class CalculatorModel
{

    
    [Required(ErrorMessage ="Please enter a number 1-100")]
        [Range(0, 100,ErrorMessage = "Please enter a number 1-100")] 
    public decimal DiscountPercent { get; set; }
    [Required(ErrorMessage = "Please enter a number 1-100")] 
    [Range(0, 100)] public decimal Subtotal { get; set; }
   

    public decimal DiscountAmount { get; set; }
    public decimal Total { get; set; }

    public decimal CalculateFutureValue()
    {
        decimal DiscountAmount = (DiscountPercent / 100) * Subtotal;


        return DiscountAmount;

    }
    public decimal CalculateTotal()
    {
        decimal Total = (Subtotal - DiscountAmount);


        return Total;

    }


}