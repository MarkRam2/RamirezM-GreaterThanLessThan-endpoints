// Mark A Ramirez
// 10/25/2022
// Greater Than Less than api
// this code will take in two inputs provided by the user and thell them weather or not the first number is greater than less than or equal to the second one
// peer reveiwed by: Kenneth Fujimura -- Everything works as it's intended. The numbers are compared properly and put out the right character outputs. Code is legible just fine, but could use a little organizing. Make sure to include a program description at the top of the code. That's basically it. Good job, Mark.




using Microsoft.AspNetCore.Mvc;

namespace RamirezM_GreaterThanLessThan.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterThanLessThanController : ControllerBase
{
    [HttpGet]
    [Route("Greater/{num1}/{num2}")]
public string hater(string num1, string num2)
{

    int Numb1 = Convert.ToInt32(num1);
    int Numb2 = Convert.ToInt32(num2);

if(Numb1 == Numb2){
    return $"number {num1} is equal to number {num2}.";
}else if(Numb1 > Numb2){
     return $"number {num1} is greater than number {num2}.";
}else{
    return $"number {num1} is less than number {num2}.";
}
}
}
