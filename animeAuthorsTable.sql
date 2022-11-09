CREATE TABLE anime_authors(
   id INT NOT NULL PRIMARY KEY,
   anime_name VARCHAR(100) NOT NULL,
   first_name VARCHAR(100) NOT NULL,
   last_name VARCHAR(100) NOT NULL,
   genre VARCHAR(20) NOT NULL,
   rating INT NOT NULL,
   email VARCHAR(200) NOT NULL UNIQUE,
   address VARCHAR(200) NOT NULL,
   created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO anime_authors (anime_name, first_name, last_name, genre, rating, email, address)
VALUES
('Naruto', 'Masashi', 'Kishimoto', 'Ninjas', '5', 'mashaiKishi@gmail.com', '2515 KingSt High Point Shai Town'),
('Demon Slayer', 'Koyoharu', 'Gotouge', 'DemonsVsHumans', '5', 'KoyoGotouge@hotmail.com', '6100 CityLight BangKok'),
('Dragon Ball', 'Yoshiro', 'Togashi', 'SuperAdventures', '4', 'Togahsi@live.com', '1550 ChinaTown Korea'),
('Bleach', 'Tite', 'Kubo', 'Soul Reapers', '5', 'Kubo@gmail.com', '100 Sumerbeas LosAngelas California'),
('Hunter-Hunter', 'Yoshiro', 'Togashi', 'Adventure', '5', 'Togashi@aol.com', '1550 ChinaTown Korea')