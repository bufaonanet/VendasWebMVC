﻿using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMVC.Models;
using VendasWebMVC.Models.Enums;

namespace VendasWebMVC.Data
{
    public class SeedingService
    {
        private VendasWebMVCContext _context;

        public SeedingService(VendasWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departament.Any() ||
               _context.Seller.Any() ||
               _context.SalesRecord.Any())
            {
                return; //O DB já está populado
            }

            var d1 = new Departament(1, "Computadores");
            var d2 = new Departament(2, "Eletrônicos");
            var d3 = new Departament(3, "Moda");
            var d4 = new Departament(4, "Livros");

            var s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            var s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            var s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            var s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            var s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            var s6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            var r1 = new SalesRecord(1, new DateTime(2020, 03, 25), 11000.0, SaleStatus.Billed, s1);
            var r2 = new SalesRecord(2, new DateTime(2020, 03, 4), 7000.0, SaleStatus.Billed, s5);
            var r3 = new SalesRecord(3, new DateTime(2020, 03, 13), 4000.0, SaleStatus.Canceled, s4);
            var r4 = new SalesRecord(4, new DateTime(2020, 03, 1), 8000.0, SaleStatus.Billed, s1);
            var r5 = new SalesRecord(5, new DateTime(2020, 03, 21), 3000.0, SaleStatus.Billed, s3);
            var r6 = new SalesRecord(6, new DateTime(2020, 03, 15), 2000.0, SaleStatus.Billed, s1);
            var r7 = new SalesRecord(7, new DateTime(2020, 03, 28), 13000.0, SaleStatus.Billed, s2);
            var r8 = new SalesRecord(8, new DateTime(2020, 03, 11), 4000.0, SaleStatus.Billed, s4);
            var r9 = new SalesRecord(9, new DateTime(2020, 03, 14), 11000.0, SaleStatus.Pending, s6);
            var r10 = new SalesRecord(10, new DateTime(2020, 04, 7), 9000.0, SaleStatus.Billed, s6);
            var r11 = new SalesRecord(11, new DateTime(2020, 04, 13), 6000.0, SaleStatus.Billed, s2);
            var r12 = new SalesRecord(12, new DateTime(2020, 04, 25), 7000.0, SaleStatus.Pending, s3);
            var r13 = new SalesRecord(13, new DateTime(2020, 04, 29), 10000.0, SaleStatus.Billed, s4);
            var r14 = new SalesRecord(14, new DateTime(2020, 04, 4), 3000.0, SaleStatus.Billed, s5);
            var r15 = new SalesRecord(15, new DateTime(2020, 04, 12), 4000.0, SaleStatus.Billed, s1);
            var r16 = new SalesRecord(16, new DateTime(2020, 05, 5), 2000.0, SaleStatus.Billed, s4);
            var r17 = new SalesRecord(17, new DateTime(2020, 05, 1), 12000.0, SaleStatus.Billed, s1);
            var r18 = new SalesRecord(18, new DateTime(2020, 05, 24), 6000.0, SaleStatus.Billed, s3);
            var r19 = new SalesRecord(19, new DateTime(2020, 05, 22), 8000.0, SaleStatus.Billed, s5);
            var r20 = new SalesRecord(20, new DateTime(2020, 05, 15), 8000.0, SaleStatus.Billed, s6);
            var r21 = new SalesRecord(21, new DateTime(2020, 05, 17), 9000.0, SaleStatus.Billed, s2);
            var r22 = new SalesRecord(22, new DateTime(2020, 05, 24), 4000.0, SaleStatus.Billed, s4);
            var r23 = new SalesRecord(23, new DateTime(2020, 05, 19), 11000.0, SaleStatus.Canceled, s2);
            var r24 = new SalesRecord(24, new DateTime(2020, 05, 12), 8000.0, SaleStatus.Billed, s5);
            var r25 = new SalesRecord(25, new DateTime(2020, 05, 31), 7000.0, SaleStatus.Billed, s3);
            var r26 = new SalesRecord(26, new DateTime(2020, 05, 6), 5000.0, SaleStatus.Billed, s4);
            var r27 = new SalesRecord(27, new DateTime(2020, 05, 13), 9000.0, SaleStatus.Pending, s1);
            var r28 = new SalesRecord(28, new DateTime(2020, 05, 7), 4000.0, SaleStatus.Billed, s3);
            var r29 = new SalesRecord(29, new DateTime(2020, 05, 23), 12000.0, SaleStatus.Billed, s5);
            var r30 = new SalesRecord(30, new DateTime(2020, 05, 12), 5000.0, SaleStatus.Billed, s2);


            _context.Departament.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
