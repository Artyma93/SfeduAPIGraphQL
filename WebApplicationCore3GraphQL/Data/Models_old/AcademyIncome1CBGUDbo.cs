using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class AcademyIncome1CBGUDbo
    {
        public int ID { get; set; }
        public string AcademyСategory { get; set; } // "Академия" - категория в 1С БГУ
        public string KindOfActivityСategory { get; set; } // "Вид деятельности" - категория в 1С БГУ
        public string BudgetSPСategory { get; set; } // "Бюджет СП" - категория в 1С БГУ
        public double BudgetIndicator { get; set; } // Бюджет - показатель в отёте в 1С БГУ
        public double EstimateIndicator { get; set; } // Смета - показатель в отёте в 1С БГУ
        public double CashIncomeIndicator { get; set; } // Кассовый доход - показатель в отёте в 1С БГУ
        public double DifferenceFromEstimateIndicator { get; set; } // Разница От Сметы - показатель в отёте в 1С БГУ, разница между сметой и кассовым доходом
        public DateTime FormationDateReport { get; set; } // Дата Формирования Отчёта - дата, когда был сформирован отчёт
        public DateTime ReportDate { get; set; } // Дата отчёта - дата, на которую был сформирован отчёт
        public DateTime ReportPeriodStartDate { get; set; } // Дата начала периода отчёта
        public DateTime ReportPeriodEndDate { get; set; } // Дата окончания периода отчёта
    }
}
