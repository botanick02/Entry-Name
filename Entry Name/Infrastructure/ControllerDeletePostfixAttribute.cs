using System;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Entry_Name.Infrastructure
{
    public class ControllerDeletePostfixAttribute :  IControllerModelConvention
    {
        public string Postfix { get; }
        public ControllerDeletePostfixAttribute(string name)
        {
            Postfix = name;
        }
        public void Apply(ControllerModel controller)
        {
            controller.ControllerName = controller.ControllerName.Replace("Controller" + Postfix, string.Empty);
        }
    }
}
