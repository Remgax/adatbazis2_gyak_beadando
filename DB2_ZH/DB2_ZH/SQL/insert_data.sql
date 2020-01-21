create or replace PROCEDURE insert_data 
( 
    p_nev IN M5APWK_szamlak.nev%TYPE,
    p_bankkartyaszam IN M5APWK_szamlak.nev%TYPE,
    p_egyenleg IN M5APWK_szamlak.egyenleg%TYPE,
    p_ujsorok OUT NUMBER
)
IS
    v_rows NUMBER;
BEGIN
    SELECT count(*) into v_rows from M5APWK_szamlak;
    
    IF check_data(p_bankkartyaszam) = TRUE THEN
        INSERT INTO szamlak (id, nev, bankkartyaszam, egyenleg)
        VALUES (get_next, p_nev, p_bankkartyaszam, p_egyenleg);
    END IF;

    IF v_rows < SQL%ROWCOUNT THEN
        p_ujsorok := p_ujsorok + 1;
    END IF;
END;