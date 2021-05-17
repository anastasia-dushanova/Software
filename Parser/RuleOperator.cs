﻿namespace Parser
{
    /// <summary>
    /// Данный класс создан для сопоставления правил
    /// нетерминалов на бумаге с программным кодом.
    public enum RuleOperator
    {
        /// <summary>
        /// Этот оператор возвращает истину, когда следующее выражение
        /// истинны хотя бы 1 раз и допускается
        /// повторение этого выражения бесконечность количество раз.
        /// </summary>
        ONE_AND_MORE,
        /// <summary>
        /// Этот оператор возвращает истину, когда выражение
        /// может не существовать, а может существовать
        /// с повторением до бесконечности раз.
        /// </summary>
        ZERO_AND_MORE,
        /// <summary>
        /// Этот оператор возвращает истину, когда
        /// одно из последующих выражений возвращает истину.
        /// </summary>
        OR,
        /// <summary>
        /// Этот оператор возвращает истину, когда
        /// последующие выражения возвращают истину.
        /// </summary>
        AND
    }
}