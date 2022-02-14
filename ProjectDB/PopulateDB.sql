INSERT INTO [dbo].[Company] VALUES (1,'BrainWare Company');

INSERT INTO [dbo].[Product] VALUES 
(1,'Pipe fitting',1.23),
(2,'10" straight',2.00),
(3,'Quarter turn',0.75),
(4,'5" straight',1.1),
(5,'2" stright',0.90);

INSERT INTO [dbo].[Order] (description, company_id) VALUES ('Our first order.', 1);

INSERT INTO [dbo].[OrderProduct] VALUES 
(1, 1, 1.23, 10),
(1, 3, 1.00, 3),
(1, 4, 1.1, 22);

INSERT INTO [dbo].[Order] (description, company_id)  VALUES ('Our Second order.', 1);

INSERT INTO [dbo].[OrderProduct] VALUES 
(2, 1, 1.23, 10),
(2, 3, 1.00, 3),
(2, 2, 2, 13),
(2, 5, 0.9, 3);

INSERT INTO [dbo].[Order] (description, company_id)  VALUES ('Our third order.', 1);

INSERT INTO [dbo].[OrderProduct] VALUES 
(3, 1, 1.23, 10),
(3, 2, 2.00, 7),
(3, 3, 0.75, 13),
(3, 4, 1.1, 5),
(3, 5, 0.9, 3);