﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickMaster.Models;

namespace QuickMaster.Controllers
{
    public class HelloController : Controller
    {
        private readonly MyContext _myContext;
        private readonly BookContext _bookContext;

        //// コンテキストクラスを取得
        //public HelloController (MyContext context)
        //{
        //    this._myContext = context;
        //}

        // コンテキストクラスを取得
        public HelloController(BookContext context)
        {
            this._bookContext = context;
        }

        public IActionResult Index()
        {
            //return View();
            return Content("Hello World!"); 
        }

        public IActionResult Greet()
        {
            // ビュー変数を準備
            ViewData["Message"] = "Hello World!";
            ViewBag.Message = "Hello World!";
            // テンプレートを呼び出す
            return View();
        }

        public IActionResult List()
        {
            // 書籍情報をビューに渡す
            return View(this._bookContext.Books);
        }
    }
}