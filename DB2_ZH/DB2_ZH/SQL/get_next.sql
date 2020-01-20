create or replace FUNCTION get_next
RETURN szamlak.id%TYPE 
IS
nextID szamlak.id%TYPE;
v_db number;

BEGIN
    SELECT COUNT(id) into v_db FROM szamlak;
    IF v_db <> 0 THEN
        SELECT MIN(id)-3 INTO nextID FROM szamlak;
        
    ELSE
        nextID := 10000;
    END IF;
    RETURN nextID;
END;