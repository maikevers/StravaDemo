using System;
using System.Collections.Generic;

namespace StravaDemo.StravaClients.Activities
{
    public class ActivityDto
    {
        public long id { get; set; }

        public int resource_state { get; set; }

        public string external_id { get; set; }

        public long upload_id { get; set; }

        public Athlete athlete { get; set; }

        public string name { get; set; }

        public int distance { get; set; }

        public int moving_time { get; set; }

        public int elapsed_time { get; set; }

        public int total_elevation_gain { get; set; }

        public string type { get; set; }

        public DateTime start_date { get; set; }

        public DateTime start_date_local { get; set; }

        public string timezone { get; set; }

        public int utc_offset { get; set; }

        public List<float> start_latlng { get; set; }

        public List<float> end_latlng { get; set; }

        public float start_latitude { get; set; }

        public float start_longitude { get; set; }

        public int achievement_count { get; set; }

        public int kudos_count { get; set; }

        public int comment_count { get; set; }

        public int athlete_count { get; set; }

        public int photo_count { get; set; }

        public Map map { get; set; }

        public bool trainer { get; set; }

        public bool commute { get; set; }

        public bool manual { get; set; }

        public bool _private { get; set; }

        public bool flagged { get; set; }

        public string gear_id { get; set; }

        public bool from_accepted_tag { get; set; }

        public float average_speed { get; set; }

        public float max_speed { get; set; }

        public float average_cadence { get; set; }

        public int average_temp { get; set; }

        public float average_watts { get; set; }

        public int weighted_average_watts { get; set; }

        public float kilojoules { get; set; }

        public bool device_watts { get; set; }

        public bool has_heartrate { get; set; }

        public int max_watts { get; set; }

        public float elev_high { get; set; }

        public float elev_low { get; set; }

        public int pr_count { get; set; }

        public int total_photo_count { get; set; }

        public bool has_kudoed { get; set; }

        public int workout_type { get; set; }

        public object suffer_score { get; set; }

        public string description { get; set; }

        public float calories { get; set; }

        public List<Segment_Efforts> segment_efforts { get; set; }

        public List<Splits_Metric> splits_metric { get; set; }

        public List<Lap> laps { get; set; }

        public Gear gear { get; set; }

        public object partner_brand_tag { get; set; }

        public Photos photos { get; set; }

        public List<Highlighted_Kudosers> highlighted_kudosers { get; set; }

        public string device_name { get; set; }

        public string embed_token { get; set; }

        public bool segment_leaderboard_opt_out { get; set; }

        public bool leaderboard_opt_out { get; set; }
    }

    public class Athlete
    {
        public int id { get; set; }

        public int resource_state { get; set; }
    }

    public class Map
    {
        public string id { get; set; }

        public string polyline { get; set; }

        public int resource_state { get; set; }

        public string summary_polyline { get; set; }
    }

    public class Gear
    {
        public string id { get; set; }

        public bool primary { get; set; }

        public string name { get; set; }

        public int resource_state { get; set; }

        public int distance { get; set; }
    }

    public class Photos
    {
        public Primary primary { get; set; }

        public bool use_primary_photo { get; set; }

        public int count { get; set; }
    }

    public class Primary
    {
        public object id { get; set; }

        public string unique_id { get; set; }

        public Urls urls { get; set; }

        public int source { get; set; }
    }

    public class Urls
    {
        public string _100 { get; set; }

        public string _600 { get; set; }
    }

    public class Segment_Efforts
    {
        public long id { get; set; }

        public int resource_state { get; set; }

        public string name { get; set; }

        public Activity activity { get; set; }

        public Athlete athlete { get; set; }

        public int elapsed_time { get; set; }

        public int moving_time { get; set; }

        public DateTime start_date { get; set; }

        public DateTime start_date_local { get; set; }

        public float distance { get; set; }

        public int start_index { get; set; }

        public int end_index { get; set; }

        public float average_cadence { get; set; }

        public bool device_watts { get; set; }

        public float average_watts { get; set; }

        public Segment segment { get; set; }

        public object kom_rank { get; set; }

        public object pr_rank { get; set; }

        public List<object> achievements { get; set; }

        public bool hidden { get; set; }
    }

    public class Activity
    {
        public long id { get; set; }

        public int resource_state { get; set; }
    }
    
    public class Segment
    {
        public int id { get; set; }

        public int resource_state { get; set; }

        public string name { get; set; }

        public string activity_type { get; set; }

        public float distance { get; set; }

        public float average_grade { get; set; }

        public float maximum_grade { get; set; }

        public float elevation_high { get; set; }

        public float elevation_low { get; set; }

        public List<float> start_latlng { get; set; }

        public List<float> end_latlng { get; set; }

        public float start_latitude { get; set; }

        public float start_longitude { get; set; }

        public float end_latitude { get; set; }

        public float end_longitude { get; set; }

        public int climb_category { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string country { get; set; }

        public bool _private { get; set; }

        public bool hazardous { get; set; }

        public bool starred { get; set; }
    }

    public class Splits_Metric
    {
        public float distance { get; set; }

        public int elapsed_time { get; set; }

        public float elevation_difference { get; set; }

        public int moving_time { get; set; }

        public int split { get; set; }

        public float average_speed { get; set; }

        public int pace_zone { get; set; }
    }

    public class Lap
    {
        public long id { get; set; }

        public int resource_state { get; set; }

        public string name { get; set; }

        public Activity activity { get; set; }

        public Athlete athlete { get; set; }

        public int elapsed_time { get; set; }

        public int moving_time { get; set; }

        public DateTime start_date { get; set; }

        public DateTime start_date_local { get; set; }

        public float distance { get; set; }

        public int start_index { get; set; }

        public int end_index { get; set; }

        public int total_elevation_gain { get; set; }

        public float average_speed { get; set; }

        public float max_speed { get; set; }

        public float average_cadence { get; set; }

        public bool device_watts { get; set; }

        public float average_watts { get; set; }

        public int lap_index { get; set; }

        public int split { get; set; }
    }

    public class Highlighted_Kudosers
    {
        public string destination_url { get; set; }

        public string display_name { get; set; }

        public string avatar_url { get; set; }

        public bool show_name { get; set; }
    }
}
