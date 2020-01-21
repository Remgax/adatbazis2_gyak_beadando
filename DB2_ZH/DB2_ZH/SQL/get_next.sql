create or replace FUNCTION M5APWK_get_next
RETURN M5APWK_szamlak.id%TYPE
DETERMINISTIC
AUTHID CURRENT_USER
AS
nextID M5APWK_szamlak.id%TYPE;
v_db number;

BEGIN
    SELECT COUNT(id) into v_db FROM M5APWK_szamlak;
    IF v_db <> 0 THEN
        SELECT MIN(id)-3 INTO nextID FROM M5APWK_szamlak;
    ELSE
        nextID := 10000;
    END IF;
    RETURN nextID;
END;