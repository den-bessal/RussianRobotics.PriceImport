﻿using Microsoft.Extensions.Configuration;
using System;

namespace RussianRobotics.PriceImport.Logic
{
    /// <summary>
    /// Предоставляет методы для обработки входящих писем, 
    /// загрузки данных из прикрепленных файлов в базу данных.
    /// </summary>
    public interface IAttachmentHandler : IDisposable
    {
        /// <summary>Выполняет подклбчение к почтовому серверу на основе настроек конфигурации.</summary>
        /// <param name="userName">Имя пользователя.</param>
        /// <param name="password">Пароль.</param>
        void Connect(string userName, string password);

        /// <summary>Выполняет инициализацию параметров на основе конфигурации.</summary>
        void Initialize(IConfiguration config);

        /// <summary>Обрабатывает все письма по всем почтовым адресам, указанным в конфигурации.</summary>
        void HandleAttachments();

        /// <summary>Обрабатывает письма, полученные от указанного адресата..</summary>
        public void HandleAttachments(string from);
    }
}