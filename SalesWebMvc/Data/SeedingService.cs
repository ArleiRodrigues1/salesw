using System;
using System.Linq;
using SalesWebMvc.Models;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;
using System.Collections.Generic;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {

            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; /* O Banco de dados ja foi populado*/
            }

            Department d1 = new Department(new int(), "Computadores");
            Department d2 = new Department(new int(), "Celulares");
            Department d3 = new Department(new int(), "Acessorios");
            Department d4 = new Department(new int(), "Ferramentas");



            Seller s1 = new Seller(new int(), "Arlei Rodrigues", "arlei@gmail.com", new DateTime(2004, 03, 11), 1000.0, d1);

            Seller s2 = new Seller(new int(), "Geovana Santos", "ge@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);

            Seller s3 = new Seller(new int(), "Lucas Silva", "lucas@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);

            Seller s4 = new Seller(new int(), "Rosa Maria", "rosa@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);

            Seller s5 = new Seller(new int(), "Aline SIlva", "aline@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);

            Seller s6 = new Seller(new int(), "Diego Ferreira", "diego@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);


            //Janeiro 2022
            SalesRecord r1 = new SalesRecord(new int(), new DateTime(2022, 01, 25), 11000.0, SaleStatus.Billed, s1);

            SalesRecord r2 = new SalesRecord(new int(), new DateTime(2022, 01, 4), 7000.0, SaleStatus.Billed, s5);

            SalesRecord r3 = new SalesRecord(new int(), new DateTime(2022, 01, 13), 4000.0, SaleStatus.Canceled, s4);

            SalesRecord r4 = new SalesRecord(new int(), new DateTime(2022, 01, 1), 8000.0, SaleStatus.Billed, s1);

            SalesRecord r5 = new SalesRecord(new int(), new DateTime(2022, 01, 21), 3000.0, SaleStatus.Billed, s3);

            SalesRecord r6 = new SalesRecord(new int(), new DateTime(2022, 01, 15), 2000.0, SaleStatus.Billed, s1);

            SalesRecord r7 = new SalesRecord(new int(), new DateTime(2022, 01, 28), 13000.0, SaleStatus.Billed, s2);

            SalesRecord r8 = new SalesRecord(new int(), new DateTime(2022, 01, 11), 4000.0, SaleStatus.Billed, s4);

            SalesRecord r9 = new SalesRecord(new int(), new DateTime(2022, 01, 14), 11000.0, SaleStatus.Pending, s6);

            SalesRecord r10 = new SalesRecord(new int(), new DateTime(2022, 01, 7), 9000.0, SaleStatus.Billed, s6);

            //Fev 2022
            SalesRecord r11 = new SalesRecord(new int(), new DateTime(2022, 02, 01), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r12 = new SalesRecord(new int(), new DateTime(2022, 02, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r13 = new SalesRecord(new int(), new DateTime(2022, 02, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r14 = new SalesRecord(new int(), new DateTime(2022, 02, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r15 = new SalesRecord(new int(), new DateTime(2022, 02, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r16 = new SalesRecord(new int(), new DateTime(2022, 02, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r17 = new SalesRecord(new int(), new DateTime(2022, 02, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r18 = new SalesRecord(new int(), new DateTime(2022, 02, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r19 = new SalesRecord(new int(), new DateTime(2022, 02, 26), 11.000, SaleStatus.Billed, s4);

            SalesRecord r20 = new SalesRecord(new int(), new DateTime(2022, 02, 28), 5000.0, SaleStatus.Billed, s5);

            //Mar 2022
            SalesRecord r21 = new SalesRecord(new int(), new DateTime(2022, 03, 01), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r22 = new SalesRecord(new int(), new DateTime(2022, 03, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r23 = new SalesRecord(new int(), new DateTime(2022, 03, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r24 = new SalesRecord(new int(), new DateTime(2022, 03, 11), 2500.0, SaleStatus.Billed, s1);

            SalesRecord r25 = new SalesRecord(new int(), new DateTime(2022, 03, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r26 = new SalesRecord(new int(), new DateTime(2022, 03, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r27 = new SalesRecord(new int(), new DateTime(2022, 03, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r28 = new SalesRecord(new int(), new DateTime(2022, 03, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r29 = new SalesRecord(new int(), new DateTime(2022, 03, 26), 11.000, SaleStatus.Billed, s4);

            SalesRecord r30 = new SalesRecord(new int(), new DateTime(2022, 03, 28), 5000.0, SaleStatus.Billed, s5);

            //Abr 2022
            SalesRecord r31 = new SalesRecord(new int(), new DateTime(2022, 04, 01), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r32 = new SalesRecord(new int(), new DateTime(2022, 04, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r33 = new SalesRecord(new int(), new DateTime(2022, 04, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r34 = new SalesRecord(new int(), new DateTime(2022, 04, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r35 = new SalesRecord(new int(), new DateTime(2022, 04, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r36 = new SalesRecord(new int(), new DateTime(2022, 04, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r37 = new SalesRecord(new int(), new DateTime(2022, 04, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r38 = new SalesRecord(new int(), new DateTime(2022, 04, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r39 = new SalesRecord(new int(), new DateTime(2022, 04, 26), 11.000, SaleStatus.Billed, s4);

            SalesRecord r40 = new SalesRecord(new int(), new DateTime(2022, 04, 28), 5000.0, SaleStatus.Billed, s5);

            //Maio 2022
            SalesRecord r41 = new SalesRecord(new int(), new DateTime(2022, 05, 01), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r42 = new SalesRecord(new int(), new DateTime(2022, 05, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r43 = new SalesRecord(new int(), new DateTime(2022, 05, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r44 = new SalesRecord(new int(), new DateTime(2022, 05, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r45 = new SalesRecord(new int(), new DateTime(2022, 05, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r46 = new SalesRecord(new int(), new DateTime(2022, 05, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r47 = new SalesRecord(new int(), new DateTime(2022, 05, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r48 = new SalesRecord(new int(), new DateTime(2022, 05, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r49 = new SalesRecord(new int(), new DateTime(2022, 05, 26), 11.000, SaleStatus.Billed, s4);

            SalesRecord r50 = new SalesRecord(new int(), new DateTime(2022, 05, 28), 5000.0, SaleStatus.Billed, s5);

            //Jun 2022
            SalesRecord r51 = new SalesRecord(new int(), new DateTime(2022, 06, 01), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r52 = new SalesRecord(new int(), new DateTime(2022, 06, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r53 = new SalesRecord(new int(), new DateTime(2022, 06, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r54 = new SalesRecord(new int(), new DateTime(2022, 06, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r55 = new SalesRecord(new int(), new DateTime(2022, 06, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r56 = new SalesRecord(new int(), new DateTime(2022, 06, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r57 = new SalesRecord(new int(), new DateTime(2022, 06, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r58 = new SalesRecord(new int(), new DateTime(2022, 06, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r59 = new SalesRecord(new int(), new DateTime(2022, 06, 26), 11.000, SaleStatus.Billed, s4);

            SalesRecord r60 = new SalesRecord(new int(), new DateTime(2022, 06, 28), 5000.0, SaleStatus.Billed, s5);

            //Jul 2022
            SalesRecord r61 = new SalesRecord(new int(), new DateTime(2022, 07, 01), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r62 = new SalesRecord(new int(), new DateTime(2022, 07, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r63 = new SalesRecord(new int(), new DateTime(2022, 07, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r64 = new SalesRecord(new int(), new DateTime(2022, 07, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r65 = new SalesRecord(new int(), new DateTime(2022, 07, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r66 = new SalesRecord(new int(), new DateTime(2022, 07, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r67 = new SalesRecord(new int(), new DateTime(2022, 07, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r68 = new SalesRecord(new int(), new DateTime(2022, 07, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r69 = new SalesRecord(new int(), new DateTime(2022, 07, 26), 11.000, SaleStatus.Billed, s4);

            SalesRecord r70 = new SalesRecord(new int(), new DateTime(2022, 07, 28), 5000.0, SaleStatus.Billed, s5);

            //Ago 2022
            SalesRecord r71 = new SalesRecord(new int(), new DateTime(2022, 08, 01), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r72 = new SalesRecord(new int(), new DateTime(2022, 08, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r73 = new SalesRecord(new int(), new DateTime(2022, 08, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r74 = new SalesRecord(new int(), new DateTime(2022, 08, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r75 = new SalesRecord(new int(), new DateTime(2022, 08, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r76 = new SalesRecord(new int(), new DateTime(2022, 08, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r77 = new SalesRecord(new int(), new DateTime(2022, 08, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r78 = new SalesRecord(new int(), new DateTime(2022, 08, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r79 = new SalesRecord(new int(), new DateTime(2022, 08, 26), 11.000, SaleStatus.Billed, s4);

            SalesRecord r80 = new SalesRecord(new int(), new DateTime(2022, 08, 28), 5000.0, SaleStatus.Billed, s5);

            //Set 2022
            SalesRecord r81 = new SalesRecord(new int(), new DateTime(2022, 09, 01), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r82 = new SalesRecord(new int(), new DateTime(2022, 09, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r83 = new SalesRecord(new int(), new DateTime(2022, 09, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r84 = new SalesRecord(new int(), new DateTime(2022, 09, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r85 = new SalesRecord(new int(), new DateTime(2022, 09, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r86 = new SalesRecord(new int(), new DateTime(2022, 09, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r87 = new SalesRecord(new int(), new DateTime(2022, 09, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r88 = new SalesRecord(new int(), new DateTime(2022, 09, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r89 = new SalesRecord(new int(), new DateTime(2022, 09, 26), 11.000, SaleStatus.Billed, s4);

            SalesRecord r90 = new SalesRecord(new int(), new DateTime(2022, 09, 28), 5000.0, SaleStatus.Billed, s5);

            //Out 2022
            SalesRecord r91 = new SalesRecord(new int(), new DateTime(2022, 10, 01), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r92 = new SalesRecord(new int(), new DateTime(2022, 10, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r93 = new SalesRecord(new int(), new DateTime(2022, 10, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r94 = new SalesRecord(new int(), new DateTime(2022, 10, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r95 = new SalesRecord(new int(), new DateTime(2022, 10, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r96 = new SalesRecord(new int(), new DateTime(2022, 10, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r97 = new SalesRecord(new int(), new DateTime(2022, 10, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r98 = new SalesRecord(new int(), new DateTime(2022, 10, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r99 = new SalesRecord(new int(), new DateTime(2022, 10, 26), 11.000, SaleStatus.Billed, s4);

            SalesRecord r100 = new SalesRecord(new int(), new DateTime(2022, 10, 28), 5000.0, SaleStatus.Billed, s5);

            //Nov 2022
            SalesRecord r101 = new SalesRecord(new int(), new DateTime(2022, 11, 01), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r102 = new SalesRecord(new int(), new DateTime(2022, 11, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r103 = new SalesRecord(new int(), new DateTime(2022, 11, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r104 = new SalesRecord(new int(), new DateTime(2022, 11, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r105 = new SalesRecord(new int(), new DateTime(2022, 11, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r106 = new SalesRecord(new int(), new DateTime(2022, 11, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r107 = new SalesRecord(new int(), new DateTime(2022, 11, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r108 = new SalesRecord(new int(), new DateTime(2022, 11, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r109 = new SalesRecord(new int(), new DateTime(2022, 11, 26), 11.000, SaleStatus.Billed, s4);

            SalesRecord r110 = new SalesRecord(new int(), new DateTime(2022, 11, 28), 5000.0, SaleStatus.Billed, s5);

            //Dez 2022
            SalesRecord r111 = new SalesRecord(new int(), new DateTime(2022, 12, 01), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r112 = new SalesRecord(new int(), new DateTime(2022, 12, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r113 = new SalesRecord(new int(), new DateTime(2022, 12, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r114 = new SalesRecord(new int(), new DateTime(2022, 12, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r115 = new SalesRecord(new int(), new DateTime(2022, 12, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r116 = new SalesRecord(new int(), new DateTime(2022, 12, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r117 = new SalesRecord(new int(), new DateTime(2022, 12, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r118 = new SalesRecord(new int(), new DateTime(2022, 12, 24), 6000.0, SaleStatus.Billed, s3);


            //Jan 2023
            SalesRecord r119 = new SalesRecord(new int(), new DateTime(2023, 01, 04), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r120 = new SalesRecord(new int(), new DateTime(2023, 01, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r121 = new SalesRecord(new int(), new DateTime(2023, 01, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r122 = new SalesRecord(new int(), new DateTime(2023, 01, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r123 = new SalesRecord(new int(), new DateTime(2023, 01, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r124 = new SalesRecord(new int(), new DateTime(2023, 01, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r125 = new SalesRecord(new int(), new DateTime(2023, 01, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r126 = new SalesRecord(new int(), new DateTime(2023, 01, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r127 = new SalesRecord(new int(), new DateTime(2023, 01, 26), 11.000, SaleStatus.Billed, s4);

            SalesRecord r128 = new SalesRecord(new int(), new DateTime(2023, 01, 28), 5000.0, SaleStatus.Billed, s5);

            //Fev 2023
            SalesRecord r129 = new SalesRecord(new int(), new DateTime(2023, 02, 04), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r130 = new SalesRecord(new int(), new DateTime(2023, 02, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r131 = new SalesRecord(new int(), new DateTime(2023, 01, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r132 = new SalesRecord(new int(), new DateTime(2023, 01, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r133 = new SalesRecord(new int(), new DateTime(2023, 01, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r134 = new SalesRecord(new int(), new DateTime(2023, 02, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r135 = new SalesRecord(new int(), new DateTime(2023, 02, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r136 = new SalesRecord(new int(), new DateTime(2023, 02, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r137 = new SalesRecord(new int(), new DateTime(2023, 02, 26), 11.000, SaleStatus.Billed, s4);



            //Mar 2023
            SalesRecord r138 = new SalesRecord(new int(), new DateTime(2023, 03, 04), 1500.0, SaleStatus.Billed, s1);

            SalesRecord r139 = new SalesRecord(new int(), new DateTime(2023, 03, 05), 3000.0, SaleStatus.Billed, s2);

            SalesRecord r140 = new SalesRecord(new int(), new DateTime(2023, 03, 09), 3500.0, SaleStatus.Pending, s3);

            SalesRecord r141 = new SalesRecord(new int(), new DateTime(2023, 03, 12), 2500.0, SaleStatus.Billed, s4);

            SalesRecord r142 = new SalesRecord(new int(), new DateTime(2023, 03, 15), 5000.0, SaleStatus.Canceled, s5);

            SalesRecord r143 = new SalesRecord(new int(), new DateTime(2023, 03, 18), 10.000, SaleStatus.Billed, s1);

            SalesRecord r144 = new SalesRecord(new int(), new DateTime(2023, 03, 20), 8000.0, SaleStatus.Pending, s2);

            SalesRecord r145 = new SalesRecord(new int(), new DateTime(2023, 03, 24), 6000.0, SaleStatus.Billed, s3);

            SalesRecord r146 = new SalesRecord(new int(), new DateTime(2023, 03, 26), 7000.0, SaleStatus.Billed, s4);

            SalesRecord r147 = new SalesRecord(new int(), new DateTime(2023, 03, 28), 5000.0, SaleStatus.Billed, s5);


            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30,
                r31, r32, r33, r34, r35, r36, r37, r38, r39, r40,
                r41, r42, r43, r44, r45, r46, r47, r48, r49, r50,
                r51, r52, r53, r54, r55, r56, r57, r58, r59, r60,
                r61, r62, r63, r64, r65, r66, r67, r68, r69, r70,
                r71, r72, r73, r74, r75, r76, r77, r78, r79, r80,
                r81, r82, r83, r84, r85, r86, r87, r88, r89, r90,
                r91, r92, r93, r94, r95, r96, r97, r98, r99, r100,
                r101, r102, r103, r104, r105, r106, r107, r108, r109, r110,
                r111, r112, r113, r114, r115, r116, r117, r118, r119, r120,
                r121, r122, r123, r124, r125, r126, r127, r128, r129, r130,
                r131, r132, r133, r134, r135, r136, r137, r138, r139, r140,
                r141, r142, r143, r144, r145, r146, r147);

            _context.SaveChanges();

        }

    }
}