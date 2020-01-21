CREATE TABLE M5APWK_szamlak(
    id INT NOT NULL, 
    nev VARCHAR2(250) NOT NULL, 
    bankkartyaszam CHAR(16) NOT NULL, 
    egyenleg INT NOT NULL CHECK (egyenleg > 0),

    CONSTRAINT PK_szamlak PRIMARY KEY(id),
    CONSTRAINT UC_bankkartya UNIQUE (bankkartyaszam)
);