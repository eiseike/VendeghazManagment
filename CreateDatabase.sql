﻿CREATE TABLE vendeg (id int IDENTITY NOT NULL, nev nvarchar(255) NOT NULL, nem bit NOT NULL, okmany_tipus tinyint NOT NULL, okmany_azonosito nvarchar(20) NOT NULL, szuletesi_datum datetime NULL, PRIMARY KEY (id));
CREATE INDEX vendeg_id ON vendeg (id);
