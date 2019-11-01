using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    // DataContract É  um contrato formal entre um serviço e um cliente que descreve abstratamente os dados a serem trocados.
    // Ou seja, para se comunicar, o cliente e o serviço não precisam compartilhar os mesmos tipos, apenas os mesmos 
    //contratos de dados.
    [DataContract]
    public abstract class BaseModel
    {
        [DataMember] //[DataMember] é aplicado ao membro de um tipo, especifica que o membro faz parte de um contrato de dados.
        public int Id { get; protected set; }
    }
}
