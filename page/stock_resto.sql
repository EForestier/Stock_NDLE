-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Ven 12 Mai 2017 à 09:26
-- Version du serveur :  5.7.14
-- Version de PHP :  5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `stock_resto`
--

-- --------------------------------------------------------

--
-- Structure de la table `article`
--

CREATE TABLE `article` (
  `id` int(11) NOT NULL,
  `nom` varchar(25) CHARACTER SET utf8 DEFAULT NULL,
  `qte` int(11) DEFAULT NULL,
  `sortie` int(11) DEFAULT NULL,
  `id_stand` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `article`
--

INSERT INTO `article` (`id`, `nom`, `qte`, `sortie`, `id_stand`) VALUES
(1, 'Frite', 9335, 1966, 1),
(2, 'Kebabs', 10000, 100, 1),
(3, 'Galette', 871, 139, 2),
(4, 'Crepe', 1005, 5, 2),
(5, 'Jambon Blanc', 5, 5, 2),
(6, 'Gruyere Rape', 5, 5, 2),
(7, 'Moelleu Chocolat', 9700, 600, 3),
(8, 'Tarte Pomme', 9700, 300, 3),
(9, 'Beignes', 9700, 300, 3),
(10, 'Clafoutis', 9700, 300, 3),
(11, 'M&n\'s', 9700, 300, 3),
(12, 'Lyon', 9700, 300, 3),
(13, 'Mars', 9700, 300, 3),
(14, 'Sauce Ketchup', 100, 0, 5),
(15, 'Sauce Moutarde', 100, 0, 5),
(16, 'Sauce Mayonnaise', 100, 0, 5),
(17, 'Panini Jambon', 300, 0, 4),
(18, 'Panini Poulet', 300, 0, 4),
(19, 'Churros', 300, 0, 4),
(20, 'Gallette Pomme Terre', 300, 0, 4),
(21, 'Nuggets', 300, 0, 4),
(22, 'Barquette', 100, 0, 5),
(23, 'Serviette', 100, 0, 5),
(24, 'Tasse cafée', 100, 0, 5),
(25, 'Confiture', 5, 5, 2),
(26, 'Chocolat', 5, 5, 2),
(27, 'Caramel', 5, 5, 2),
(28, 'Beurre', 5, 5, 2),
(29, 'Frite', 1000, NULL, 6),
(30, 'Kebebas', 1000, NULL, 6),
(33, 'Gauffre', 1000, NULL, 3),
(35, 'Boudin', 1000, NULL, 2),
(36, 'Flan', 1000, NULL, 3),
(37, 'Boudin', 1000, NULL, 6),
(39, 'Saussices', 10000, NULL, 6),
(40, 'Flan', 1000, NULL, 7),
(41, 'test', 1000, NULL, 9),
(42, 'test', 1000, NULL, 12),
(44, 'test', 1000, NULL, 10),
(45, 'TEST', 999, 64333462, 11);

-- --------------------------------------------------------

--
-- Structure de la table `login_stand`
--

CREATE TABLE `login_stand` (
  `id` int(11) NOT NULL,
  `login_stand` varchar(25) DEFAULT NULL,
  `id_stand` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `login_stand`
--

INSERT INTO `login_stand` (`id`, `login_stand`, `id_stand`) VALUES
(1, 'organisateur', 13);

-- --------------------------------------------------------

--
-- Structure de la table `stand`
--

CREATE TABLE `stand` (
  `id` int(11) NOT NULL,
  `nom_stand` varchar(25) DEFAULT NULL,
  `id_login_stand` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `stand`
--

INSERT INTO `stand` (`id`, `nom_stand`, `id_login_stand`) VALUES
(1, 'Barbeuck Erdre', NULL),
(2, 'Crêperie Erdre', NULL),
(3, 'Confiseries Erdre', NULL),
(4, 'Chiken & Regal Erdre', NULL),
(5, 'Consomable Erdre', NULL),
(6, 'Barbeuck du château', NULL),
(7, 'Confiseries Château', NULL),
(9, 'Chiken & Regal Château', NULL),
(10, 'Consomable Château', NULL),
(11, 'Pâtes', NULL),
(12, 'Vin - Formage', NULL),
(13, 'organisateur', 1);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `article`
--
ALTER TABLE `article`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_article_id_stand` (`id_stand`);

--
-- Index pour la table `login_stand`
--
ALTER TABLE `login_stand`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_login_stand_id_stand` (`id_stand`);

--
-- Index pour la table `stand`
--
ALTER TABLE `stand`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_stand_id_login_stand` (`id_login_stand`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `article`
--
ALTER TABLE `article`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `article`
--
ALTER TABLE `article`
  ADD CONSTRAINT `FK_article_id_stand` FOREIGN KEY (`id_stand`) REFERENCES `stand` (`id`);

--
-- Contraintes pour la table `login_stand`
--
ALTER TABLE `login_stand`
  ADD CONSTRAINT `FK_login_stand_id_stand` FOREIGN KEY (`id_stand`) REFERENCES `stand` (`id`);

--
-- Contraintes pour la table `stand`
--
ALTER TABLE `stand`
  ADD CONSTRAINT `FK_stand_id_login_stand` FOREIGN KEY (`id_login_stand`) REFERENCES `login_stand` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
