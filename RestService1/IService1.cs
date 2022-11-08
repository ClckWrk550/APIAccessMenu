using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet]
        double PiValue();

        [OperationContract]
        [WebGet(UriTemplate = "add2?x={x}&y={y}")]
        int addition(int x, int y);

        [OperationContract]
        [WebGet(UriTemplate = "sub2?x={x}&y={y}")]
        int subtraction(int x, int y);

        [OperationContract]
        [WebGet(UriTemplate = "mult2?x={x}&y={y}")]
        int multiplication(int x, int y);

        [OperationContract]
        [WebGet(UriTemplate = "div2?x={x}&y={y}")]
        int division(int x, int y);
    }
}
