﻿using GestaoProdutos.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace GestaoProdutos.App.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly INotificador _notificador;

        protected BaseController(INotificador notificador)
        {
            _notificador = notificador;
        }
        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }
    }
}