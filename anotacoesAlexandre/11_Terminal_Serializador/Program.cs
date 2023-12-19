using System;
using System.Collections.Generic;

namespace _11_Terminal_Serializador
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TESTANDO SERIALIZACAO");

            List<Paciente> pacientes = new List<Paciente>();

            pacientes.Add( new Paciente("Alexandre", "08/09/1974", "4234234234") );
            pacientes.Add( new Paciente("Carol", "08/09/2006", "12335667") );
            pacientes.Add( new Paciente("Pedro", "07/01/2014", "4235534234") );
            
            foreach (var i in pacientes) {
                Console.WriteLine(i);
            }

            Console.WriteLine("SOAP ");
            Serializador.serializarSOAP(pacientes, @"pacientes.soap");
            Serializador.deserializarSOAP(pacientes, @"pacientes.soap");

            Console.WriteLine("XML");
            Serializador.serializarXML(pacientes, @"pacientes.xml");
            Serializador.deserializarXML(pacientes, @"pacientes.xml");

            Console.WriteLine("JSON");
            Serializador.serializarJSON(pacientes, @"pacientes.json");
            Serializador.deserializarJSON(pacientes, @"pacientes.json");


        }
    }
}
