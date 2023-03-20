﻿namespace HetDepot.Settings.Model
{
    public class Setting
    {
        private Dictionary<string, string> _consoleText;
        private HashSet<string> _tourTime;
        private int _maxReservationsPerTour;

        public Setting()
        {
			_consoleText = ExampleConsole();
			_tourTime = ExampleTourTime();
            _maxReservationsPerTour = 13;
        }

		public Dictionary<string, string> ConsoleText { get { return _consoleText; } }
        public HashSet<string> TourTimes { get { return _tourTime; } }
        public int MaxReservationsPerTour { get {  return _maxReservationsPerTour; } }

		private Dictionary<string, string> ExampleConsole()
		{
            return new Dictionary<string, string>()
			{
				{ "consoleLogonOpeningWelcome", "Meld u aan op de console" }
            ,   {"consoleVisitorReservationMaking", "U kunt een reservering maken door een tijdstip te selecteren."}
            ,   {"consoleVisitorReservationAlreadyHavingOne", "U heeft al een reservering. Als u een ander tijdstip selecteert, wordt uw reservering gewijzigd. Als u uw huidige reservering selecteert, wordt deze geannuleerd."}
			,   {"consoleVisitorLogonCodeInvalid", "De code is niet geldig. Controleer uw code en probeer het nog eens."}
			,   {"consoleVisitorReservationGroupOption", "Aanmelden groep"}
			,   {"consoleVisitorReservationNoMoreTours", "Er zijn geen rondleidingen meer beschikbaar"}
			,   {"consoleVisitorReservationConfirmation", "Uw inschrijving is bevestigd"}
			,   {"consoleVisitorReservationGroupStart", "U wordt gevraagd om alle unieke codes in te voeren. De maximale grootte is {instelling maximale grootte rondleiding}. Als u klaar bent, voert u in \u201Cgereed\u201D"}
			,   {"consoleVisitorReservationGroupEnd", "De grootte van uw gezelschap is {groepsgrootte}"}
			,   {"consoleVisitorReservationMaximumForTour", "Het maximum aantal deelnemers is bereikt."}
			,   {"consoleVisitorReservationCancellationRequestionConfirmation", "Wilt u deze rondleiding annuleren? Ja/Nee."}
			,   {"consoleVisitorReservationCancellationConfirmation", "Reservering geannuleerd"}
			,   {"consoleVisitorReservationChangeTourConfirmation", "U bent uitgeschreven voor {tijdstip}\u201D. Uw nieuwe rondleiding start om {tijdstip}"}
			,   {"consoleGuideTourVisitorValidationStart", "U kunt de rondleiding starten."}
			,   {"consoleGuideLogonCodeInvalid", "Uw code is niet geldig. Werkt u hier wel?"}
			,   {"consoleGuideTourCurrent", "Huidige rondleiding {tijdstip n}"}
			,   {"consoleGuideTourStart", "Rondleiding starten?"}
			,   {"consoleGuideTourNoToursAvailable", "Er zijn geen rondleidingen meer beschikbaar"}
			,   {"consoleGuideTourVisitorValidationStarted", "Er zijn { aantal reserveringen}"}
			,   {"consoleGuideTourVisitorValidationVisitorValidated", "{aantal} van {reserveringen} aangemeld."}
			,   {"consoleGuideTourVisitorValidationVisitorNextVisitor", "Volgende aanmelding"}
			,   {"consoleGuideTourVisitorAddWithoutReservationOption", "Aanmelden zonder reservering"}
			,   {"consoleGuideTourVisitorTourStartOption", "Starten rondleiding"}
			,   {"consoleGuideTourAllReservationsValidated", "Alle deelnemers zijn aangemeld."}
			,   {"consoleGuideTourVisitorAddWithoutReservationConfirmation", "Bezoeker toegevoegd. {aantal} van {reserveringen} aangemeld."}
			,   {"consoleManagerTicketsLoaded", "Met succes entreebewijzen geladen"}
			,   {"consoleManagerShowOptions", "Laad entreebewijzen voor de dag\nLaad instellingen\nBekijk rondleidinggegevens."}
			,   {"consoleManagerLogonCodeInvalid", "Uw code is niet geldig."}
			,   {"consoleVisitorAlreadyHasTourAdmission", "U heeft al deelgenomen aan een rondleiding vandaag. Morgen weer een kans."}
			};
		}
		private HashSet<string> ExampleTourTime()
		{
			return new HashSet<string> { "11:00", "11:20", "11:40", "12:00", "12:20", "12:40", "13:00", "13:20", "13:40", "14:00" } ;
		}
	}


}
