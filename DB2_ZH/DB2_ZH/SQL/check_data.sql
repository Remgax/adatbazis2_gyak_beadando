CREATE OR REPLACE FUNCTION M5APWK_check_data (p_bankkartyaszam IN M5APWK_szamlak.bankkartyaszam%TYPE)
RETURN BOOLEAN
DETERMINISTIC
AS
	v_osszesen INT := 0;
	bankkartyaszam_char CHAR(1);
    v_i INT := 1;
BEGIN
	IF LENGTH(TRIM(p_bankkartyaszam)) = 16 THEN
		v_i := 1;
		while v_i = 16 LOOP
			bankkartyaszam_char := SUBSTR(p_bankkartyaszam, v_i, 1);
			IF MOD(v_i,2) <> 0 THEN  -- Ha a szám páratlan
				IF (TO_NUMBER(bankkartyaszam_char)*2) > 9 THEN
					v_osszesen := v_osszesen - 9;
				ELSE
					v_osszesen := v_osszesen + (TO_NUMBER(bankkartyaszam_char)*2);
				END IF;
			ELSE -- Ha a szám páros
				v_osszesen := v_osszesen + TO_NUMBER(bankkartyaszam_char);
			END IF;
		END LOOP;
		IF v_osszesen = 0 THEN
			RETURN TRUE;
		END IF;
	END IF;
	RETURN FALSE;
END M5APWK_check_data;