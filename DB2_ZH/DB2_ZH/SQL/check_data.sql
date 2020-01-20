CREATE OR REPLACE FUNCTION check_data (p_bankkartyaszam IN szamla.bankkartyaszam%TYPE)
RETURN INT
DETERMINISTIC AS


	bankkartyaszam_char CHAR(1);
    i INT;

BEGIN
	
	IF LENGTH(TRIM(p_bankkartyaszam)) = 16 THEN
		
		i := 1;

		while i = 16 LOOP
			
			bankkartyaszam_char := SUBSTR(p_bankkartyaszam, i, 1);

			

		END LOOP;

		RETURN 1;

	END IF;

	RETURN 0;

END check_data;