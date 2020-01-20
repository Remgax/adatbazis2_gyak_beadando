CREATE TABLE szamlak(
    id INT NOT NULL, 
    nev VARCHAR2(250) NOT NULL, 
    bankkartyaszam CHAR(16) NOT NULL, 
    egyenleg INT NOT NULL,
    
    CONSTRAINT PK_szamlak PRIMARY KEY(id)
);