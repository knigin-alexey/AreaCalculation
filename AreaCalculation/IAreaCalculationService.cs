using AreaCalculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation
{
    /// <summary>
    /// Данная реализация является следствием требования "Вычисление площади фигуры без знания типа фигуры"
    /// Если модуль, отвечающий за вычисление площади фигуры, должен работать с типами фигур по интерфейсу,
    /// то значит, что фигура является клиентским типом, инкапсулирующим свою функциональность.
    /// Для предоставления клиенту IAreaCalculationService можно создать расширение для используемого 
    /// контейнера внедрения зависимостей
    /// </summary>
    public interface IAreaCalculationService
    {
        double CalculateArea(IGetAreaShape shape);
    }
}
