using PersonalAccount.Intefaces;
using PersonalAccount.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalAccount.Mocks
{   
    public class MockSchedule : ISchedule
    {

        private readonly IDays _days = new MockDay();
        public IEnumerable<Schedule> Schedule 
        {
            get
            {
                return new List<Schedule>
                {
                    new Schedule {Day="Понедельник", Place1="2-Л2", Subject1="Экономика", SubType1="Лекция", Teacher1="Гоманчук Олег Геннадьевич",
                    Place2="12-207", Subject2="Численные методы", SubType2="Лекция", Teacher2="Толоконников Лев Алексеевич",
                    Place3="12-205", Subject3="Объектно-ориентированное программирование", SubType3="Лекция", Teacher3="Скобельцын Сергей Алексеевич",
                    Place4="12-209", Subject4="Компьютерная графика", SubType4="Лабораторное", Teacher4="Горбачев Дмитрий Викторович",
                    Place5="12-211", Subject5="Объектно-ориентированное программирование", SubType5="Лабораторная", Teacher5="Скобельцын Сергей Алексеевич"},


                    new Schedule {Day="Вторник", Place1="", Subject1="", SubType1="", Teacher1="",
                    Place2="12-104", Subject2="Теория вероятностей и математическая статистика", SubType2="Лекция", Teacher2="Кочетыгов Александр Алексеевич",
                    Place3="Спорткорпус", Subject3="Физическая культура и спорт", SubType3="Практика", Teacher3="Перова Ирина Николаевна",
                    Place4="12-313", Subject4="Теория вероятностей и математическая статистика", SubType4="Практическое", Teacher4="Кочетыгов Александр Алексеевич",
                    Place5="", Subject5="", SubType5="", Teacher5=""},

                   new Schedule {Day="Среда", Place1="12-207", Subject1="Численные методы", SubType1="Лабораторное", Teacher1="Толоконников Лев Алексеевич",
                    Place2="12-305", Subject2="Уравнения математической физики", SubType2="Лекция", Teacher2="Кузнецов Андрей Владимирович",
                    Place3="12-209", Subject3="Компьютерная графика", SubType3="Лабораторное", Teacher3="Горбачев Дмитрий Викторович",
                    Place4="12-211", Subject4="Объектно-ориентированное программирование", SubType4="Лабораторное", Teacher4="Скобельцын Сергей Алексеевич",
                    Place5="", Subject5="", SubType5="", Teacher5=""},

                    new Schedule {Day="Четверг", Place1="", Subject1="", SubType1="", Teacher1="",
                    Place2="12-205", Subject2="Численные методы", SubType2="Лекция", Teacher2="Толоконников Лев Алексеевич",
                    Place3="12-205", Subject3="Компьютерная графика", SubType3="Лекция", Teacher3="Скобельцын Сергей Алексеевич",
                    Place4="12-209", Subject4="Компьютерная графика", SubType4="Лабораторная", Teacher4="Скобельцын Сергей Алексеевич",
                    Place5="12-205", Subject5="Уравнения математической физики", SubType5="Практическое", Teacher5="Кузнецов Андрей Владимирович"},

                    new Schedule {Day="Пятница", Place1="2-Л2", Subject1="Экономика", SubType1="Практическое", Teacher1="Гоманчук Олег Геннадьевич",
                    Place2="Спорткорпус	", Subject2="Физическая культура и спорт", SubType2="Практическое", Teacher2="Перова Ирина Николаевна",
                    Place3="12-205", Subject3="Объектно-ориентированное программирование", SubType3="Лекция", Teacher3="Скобельцын Сергей Алексеевич",
                    Place4="12-209", Subject4="Функциональный анализ", SubType4="Лекция", Teacher4="Иванов Валерий Иванович",
                    Place5="", Subject5="", SubType5="", Teacher5=""},
                };
            }
        }

        public Schedule getObjectSchedule(int SchId)
        {
            throw new System.NotImplementedException();
        }
    }
}
