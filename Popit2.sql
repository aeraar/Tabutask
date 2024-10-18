-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Окт 14 2024 г., 12:53
-- Версия сервера: 10.4.32-MariaDB
-- Версия PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `управлениезаданиями`
--

-- --------------------------------------------------------

--
-- Структура таблицы `администраторы`
--

CREATE TABLE `администраторы` (
  `ID_Администратора` int(11) NOT NULL,
  `Логин` varchar(50) NOT NULL,
  `Пароль` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `администраторы`
--

INSERT INTO `администраторы` (`ID_Администратора`, `Логин`, `Пароль`) VALUES
(322, 'Beastmaster', '2312@1zxc');

-- --------------------------------------------------------

--
-- Структура таблицы `задания`
--

CREATE TABLE `задания` (
  `ID_Задания` int(11) NOT NULL,
  `Сотрудник` int(11) DEFAULT NULL,
  `Дата` date DEFAULT NULL,
  `Важность` varchar(50) DEFAULT NULL,
  `Задание` varchar(5000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `сотрудники`
--

CREATE TABLE `сотрудники` (
  `ID_Сотрудника` int(11) NOT NULL,
  `ФИО` varchar(255) NOT NULL,
  `Логин` varchar(25) NOT NULL,
  `Пароль` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `администраторы`
--
ALTER TABLE `администраторы`
  ADD PRIMARY KEY (`ID_Администратора`),
  ADD UNIQUE KEY `Логин` (`Логин`);

--
-- Индексы таблицы `задания`
--
ALTER TABLE `задания`
  ADD PRIMARY KEY (`ID_Задания`),
  ADD KEY `Сотрудник` (`Сотрудник`);

--
-- Индексы таблицы `сотрудники`
--
ALTER TABLE `сотрудники`
  ADD PRIMARY KEY (`ID_Сотрудника`),
  ADD UNIQUE KEY `Логин` (`Логин`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `администраторы`
--
ALTER TABLE `администраторы`
  MODIFY `ID_Администратора` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=323;

--
-- AUTO_INCREMENT для таблицы `задания`
--
ALTER TABLE `задания`
  MODIFY `ID_Задания` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `сотрудники`
--
ALTER TABLE `сотрудники`
  MODIFY `ID_Сотрудника` int(11) NOT NULL AUTO_INCREMENT;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `задания`
--
ALTER TABLE `задания`
  ADD CONSTRAINT `задания_ibfk_1` FOREIGN KEY (`Сотрудник`) REFERENCES `сотрудники` (`ID_Сотрудника`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
