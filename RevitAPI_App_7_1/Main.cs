﻿using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Создайте приложение для генерации нескольких листов выбранного формата. Приложение
//работает следующим образом: открывается окно со списком типов семейств
//«Основные надписи» («Title block»). Ниже в поле вписывается количество создаваемых
//листов. В конце пользователь нажимает кнопку «Создать листы». В модели
//создаётся указанное количество листов определённого типа.
//Добавьте возможность выбора вида, который должен вставляться в каждый
//новый лист.
//Добавьте возможность заполнения параметра «Designed By» из текстового поля для
//всех создаваемых листов.

namespace RevitAPI_App_7_1

{
    [Transaction(TransactionMode.Manual)]

    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var mainView = new MainView(commandData);
            mainView.ShowDialog();
            return Result.Succeeded;
        }
    }
}
