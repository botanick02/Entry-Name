using System;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Entry_Name.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ControllerDeletePostfixAttribute : Attribute, IControllerModelConvention
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
