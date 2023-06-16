


using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

public class Funcionario
{
    private string matricula;
    private string cpf;
    private string nome; 
    private string funcao;
    private double salario;
    

    public Funcionario(string matricula, string cpf, string nome, string funcao, double salario)
    {
        this.matricula = matricula;
        this.cpf = cpf;
        this.nome = nome;
        this.funcao = funcao;
        this.salario = salario;
       
    }
    public (string, string, string, string, double) CalcularSalario()
    {
        string funcao = this.funcao;
        string medico;
        string TI;
        string adm;
        double salario = 2000;


        if (medico >= 2000)
        {
            return = salario + (2000 * 20 / 100);
        }


    }
}
