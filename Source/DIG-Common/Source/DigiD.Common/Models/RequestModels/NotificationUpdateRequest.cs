// De openbaarmaking van dit bestand is in het kader van de WOO geschied en 
// dus gericht op transparantie en niet op hergebruik. In het geval dat dit 
// bestand hergebruikt wordt, is de EUPL licentie van toepassing, met 
// uitzondering van broncode waarvoor een andere licentie is aangegeven.
//
// Het archief waar dit bestand deel van uitmaakt is te vinden op:
//   https://github.com/MinBZK/woo-verzoek-broncode-digid-app
//
// Eventuele kwetsbaarheden kunnen worden gemeld bij het NCSC via:
//   https://www.ncsc.nl/contact/kwetsbaarheid-melden
// onder vermelding van "Logius, openbaar gemaakte broncode DigiD-App" 
//
// Voor overige vragen over dit WOO-verzoek kunt u mailen met:
//   mailto://open@logius.nl
//
﻿using Newtonsoft.Json;

namespace DigiD.Common.Models.RequestModels
{
    public class NotificationUpdateRequest : BaseRequest
    {
        [JsonProperty("notification_id")]
        public string NotificationToken { get; set; }
        
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        [JsonProperty("user_app_id")]
        public string UserAppId { get; set; }
    }
}