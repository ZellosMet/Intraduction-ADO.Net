CREATE PROCEDURE [dbo].[AddSchedule]
	@discipline	SMALLINT,
	@teacher INT,
	@group	INT,
	@start_date	DATE,
	@start_time	TIME
AS
	BEGIN
		DECLARE @number_of_lessons TINYINT = (SELECT number_of_lessons FROM Disciplines WHERE discipline_id = @discipline)
		DECLARE @counter INT = 0
		DECLARE @time TIME = @start_time

		WHILE(@counter < @number_of_lessons)
			BEGIN
				INSERT INTO Schedule(discipline, techer, [date], [time], spent, [group] )
				VALUES				(@discipline, @teacher, @start_date, @time, IIF(@start_date < GETDATE(),  1, 0), @group);
				SET @counter = @counter + 1;

				IF  (@counter % 2 = 0 )
					SET @start_date = IIF(DATEPART (dw, @start_date) = 6,  DATEADD(dd, 3, @start_date), DATEADD(dd, 2, @start_date))
				SET @time = IIF(@time=@start_time, DATEADD(mi, 90, CONVERT(TIME, @time)), @start_time)	
			END;
	END