using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using Newtonsoft.Json;

namespace _17_WinFormsApp_SerializadorJSON
{
    public class Serializador
    {
        public static void serializarXML(List<Paciente> lista, string dadosArquivo)
        {
            try
            {
                FileStream procurador = new FileStream(@dadosArquivo, FileMode.Create);

                //atencao: preparando o serializador para receber uma lista
                XmlSerializer serializadorXML = new XmlSerializer(typeof(List<Paciente>));

                //serializador recebendo uma lista
                serializadorXML.Serialize(procurador, lista);

                procurador.Close();

                MessageBox.Show("Sucesso para serializar com XML", "Alerta");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static void deserializarXML(List<Paciente> lista, string dadosArquivo)
        {
            try
            {
                using (var procurador = new StreamReader(@dadosArquivo))
                {
                    //atenção: preparando o serializador para receber uma lista
                    XmlSerializer serializadorXML = new XmlSerializer(typeof(List<Paciente>));

                    //serializador guardando dados do arquivo xml na lista
                    lista.Clear();
                    lista.AddRange((List<Paciente>)serializadorXML.Deserialize(procurador));
                }

                string resposta = "";
                foreach (Paciente i in lista)
                {
                    resposta = resposta + i.Nome + "\n";
                }

                MessageBox.Show(resposta, "Alerta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static void serializarSOAP(List<Paciente> lista, string dadosArquivo)
        {
            try
            {
                FileStream procurador = new FileStream(@dadosArquivo, FileMode.Create);

                SoapFormatter serializadorSOAP = new SoapFormatter();

                serializadorSOAP.Serialize(procurador, lista);
                procurador.Close();

                MessageBox.Show("Sucesso para serializar com XML", "Alerta");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static void deserializarSOAP(List<Paciente> lista, string dadosArquivo)
        {
            try
            {
                using (var procurador = new FileStream(@dadosArquivo, FileMode.Open))
                {
                    SoapFormatter serializadorSOAP = new SoapFormatter();
                    lista.Clear();
                    lista.AddRange((List<Paciente>)serializadorSOAP.Deserialize(procurador));
                }

                string resposta = "";
                foreach (Paciente i in lista)
                {
                    resposta = resposta + i.Nome + "\n";
                }

                MessageBox.Show(resposta, "Alerta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static void serializarJSON(List<Paciente> lista, string dadosArquivo)
        {
            try
            {
                StreamWriter procurador = new StreamWriter(dadosArquivo);

                JsonSerializer serializadorJSON = new JsonSerializer();
                serializadorJSON.Formatting = Formatting.Indented;


                JsonWriter escritorJSON = new JsonTextWriter(procurador);
                serializadorJSON.Serialize(escritorJSON, lista);

                procurador.Close();
                escritorJSON.Close();

                MessageBox.Show("Sucesso para serializar com JSON", "Alerta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static void deserializarJSON(List<Paciente> lista, string dadosArquivo)
        {
            try
            {
                string json = File.ReadAllText(@dadosArquivo);
                lista.Clear();

                lista.AddRange(JsonConvert.DeserializeObject<List<Paciente>>(json));

                string resposta = "";
                foreach (Paciente i in lista)
                {
                    resposta = resposta + i.Nome + "\n";
                }

                MessageBox.Show(resposta, "Alerta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
