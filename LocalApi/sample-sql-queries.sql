-- SELECT * FROM Locals;


-- INSERT INTO Locals (
--   Name,
--   Location,
--   Cuisine,
--   Blerb,
--   Rating
-- )

-- VALUES (
--   'Rudys',
--   '24th and SE Powell BLVD',
--   'Pizza',
--   'really good pizza, thick crust. they have non vegan pizza too, if thats your thing',
--   9
-- );

-- SELECT * FROM Locals
-- WHERE Rating BETWEEN 4 AND 8;

-- SELECT Name
-- FROM (SELECT * FROM Locals
-- WHERE Rating > 8) AS top_restuarants;

-- SELECT Name, Rating 
-- FROM (SELECT * FROM Locals
-- WHERE Rating > 8) AS top_restuarants;

-- SELECT Name, Rating 
-- FROM (SELECT * FROM Locals
-- WHERE Rating >= 8) AS top_restuarants;

-- SELECT Name, Rating 
-- FROM (SELECT * FROM Locals
-- WHERE Rating >= 8) AS top_restuarants
-- ORDER BY Rating DESC;

SELECT Name, Rating 
FROM (SELECT * FROM Locals
WHERE Rating >= 8) AS top_restuarants
ORDER BY Rating DESC
LIMIT 5;