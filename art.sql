CREATE DATABASE  IF NOT EXISTS `art`;
USE `art`;

DROP TABLE IF EXISTS `pieces`;
CREATE TABLE `pieces` (
  `PieceID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Artist` varchar(45) NOT NULL,
  `Price` decimal(8,2) NOT NULL,
  `Description` varchar(256) NOT NULL,
  `Image` varchar(256) NOT NULL,
  PRIMARY KEY (`PieceID`),
  UNIQUE KEY `PieceID_UNIQUE` (`PieceID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

LOCK TABLES `pieces` WRITE;
INSERT INTO `pieces` VALUES (1, "Spaghetti and Cats", "AIesha", 399.00, "Two cats enjoy some Italian cooking.", "Cat_1.jpg"), (2, "Starry Koala", "AIden", 499.00, "Cosmic koalas dream of a starry night.", "Wave_1.jpg"), (3, "The New Artist", "DAIvinchie", 599.00, "A freshly made artist makes their first piece.", "Robot_1.webp");
UNLOCK TABLES;