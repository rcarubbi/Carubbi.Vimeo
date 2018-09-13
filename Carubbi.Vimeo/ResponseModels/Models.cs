using System;
using System.Collections.Generic;

namespace Carubbi.Vimeo.ResponseModels
{

    public class Paging
    {
        public string next { get; set; }
        public object previous { get; set; }
        public string first { get; set; }
        public string last { get; set; }
    }

    public class Live
    {
        public bool streaming { get; set; }
        public bool archived { get; set; }
    }

    public class StaffPick
    {
        public bool normal { get; set; }
        public bool best_of_the_month { get; set; }
        public bool best_of_the_year { get; set; }
        public bool premiere { get; set; }
    }

    public class Badges
    {
        public bool hdr { get; set; }
        public Live live { get; set; }
        public StaffPick staff_pick { get; set; }
        public bool vod { get; set; }
        public bool weekend_challenge { get; set; }
    }

    public class Embed
    {
        public string html { get; set; }
        public Badges badges { get; set; }
    }

    public class Privacy
    {
        public string view { get; set; }
        public string embed { get; set; }
        public bool download { get; set; }
        public bool add { get; set; }
        public string comments { get; set; }
    }

    public class Size
    {
        public int width { get; set; }
        public int height { get; set; }
        public string link { get; set; }
        public string link_with_play_button { get; set; }
    }

    public class Pictures
    {
        public string uri { get; set; }
        public bool active { get; set; }
        public string type { get; set; }
        public List<Size> sizes { get; set; }
        public string resource_key { get; set; }
    }

    public class Stats
    {
        public int? plays { get; set; }
    }

    public class Comments
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Credits
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Likes
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Pictures2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Texttracks
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Related
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
    }

    public class Connections
    {
        public Comments comments { get; set; }
        public Credits credits { get; set; }
        public Likes likes { get; set; }
        public Pictures2 pictures { get; set; }
        public Texttracks texttracks { get; set; }
        public Related related { get; set; }
    }

    public class Watchlater
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public bool added { get; set; }
        public object added_time { get; set; }
    }

    public class Like
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public bool added { get; set; }
        public object added_time { get; set; }
    }

    public class Report
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public List<string> reason { get; set; }
    }

    public class Interactions
    {
        public Watchlater watchlater { get; set; }
        public Like like { get; set; }
        public Report report { get; set; }
    }

    public class Metadata
    {
        public Connections connections { get; set; }
        public Interactions interactions { get; set; }
    }

    public class Size2
    {
        public int width { get; set; }
        public int height { get; set; }
        public string link { get; set; }
    }

    public class Pictures3
    {
        public string uri { get; set; }
        public bool active { get; set; }
        public string type { get; set; }
        public List<Size2> sizes { get; set; }
        public string resource_key { get; set; }
    }

    public class Activities
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
    }

    public class Albums
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Appearances
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Channels
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Feed
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
    }

    public class Followers
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Following
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Groups
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Likes2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class ModeratedChannels
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Portfolios
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Videos
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Shared
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Pictures4
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Connections2
    {
        public Activities activities { get; set; }
        public Albums albums { get; set; }
        public Appearances appearances { get; set; }
        public Channels channels { get; set; }
        public Feed feed { get; set; }
        public Followers followers { get; set; }
        public Following following { get; set; }
        public Groups groups { get; set; }
        public Likes2 likes { get; set; }
        public ModeratedChannels moderated_channels { get; set; }
        public Portfolios portfolios { get; set; }
        public Videos videos { get; set; }
        public Shared shared { get; set; }
        public Pictures4 pictures { get; set; }
    }

    public class Follow
    {
        public bool added { get; set; }
        public object added_time { get; set; }
        public string uri { get; set; }
    }

    public class Block
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public bool added { get; set; }
        public object added_time { get; set; }
    }

    public class Report2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public List<string> reason { get; set; }
    }

    public class Interactions2
    {
        public Follow follow { get; set; }
        public Block block { get; set; }
        public Report2 report { get; set; }
    }

    public class Metadata2
    {
        public Connections2 connections { get; set; }
        public Interactions2 interactions { get; set; }
    }

    public class Videos2
    {
        public object privacy { get; set; }
    }

    public class Preferences
    {
        public Videos2 videos { get; set; }
    }

    public class User
    {
        public string uri { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string location { get; set; }
        public string bio { get; set; }
        public DateTime created_time { get; set; }
        public Pictures3 pictures { get; set; }
        public List<object> websites { get; set; }
        public Metadata2 metadata { get; set; }
        public string resource_key { get; set; }
        public string account { get; set; }
        public Preferences preferences { get; set; }
    }

    public class App
    {
        public string name { get; set; }
        public string uri { get; set; }
    }

    public class Upload
    {
        public string status { get; set; }
        public object link { get; set; }
        public object upload_link { get; set; }
        public object complete_uri { get; set; }
        public object form { get; set; }
        public object approach { get; set; }
        public object size { get; set; }
        public object redirect_url { get; set; }
    }

    public class Transcode
    {
        public string status { get; set; }
    }

    public class Buttons
    {
        public bool like { get; set; }
        public bool watchlater { get; set; }
        public bool share { get; set; }
        public bool embed { get; set; }
        public bool vote { get; set; }
        public bool hd { get; set; }
    }

    public class Logos
    {
        public bool vimeo { get; set; }
        public bool custom { get; set; }
        public bool sticky_custom { get; set; }
    }

    public class StreamClips
    {
        public List<object> video { get; set; }
    }

    public class Settings
    {
        public Buttons buttons { get; set; }
        public Logos logos { get; set; }
        public string outro { get; set; }
        public bool autopause { get; set; }
        public bool autoplay { get; set; }
        public bool background { get; set; }
        public List<object> cards { get; set; }
        public string color { get; set; }
        public bool loop { get; set; }
        public bool muted { get; set; }
        public string outro_secondary_link_name { get; set; }
        public string outro_secondary_link_url { get; set; }
        public string outro_text_title { get; set; }
        public bool link { get; set; }
        public int overlay_email_capture { get; set; }
        public string overlay_email_capture_confirmation { get; set; }
        public object overlay_email_capture_text { get; set; }
        public bool playsinline { get; set; }
        public bool responsive { get; set; }
        public bool show_360_label { get; set; }
        public bool badge { get; set; }
        public string byline { get; set; }
        public bool byline_badge { get; set; }
        public bool collections_button { get; set; }
        public bool show_compass { get; set; }
        public bool fullscreen_button { get; set; }
        public bool playbar { get; set; }
        public string portrait { get; set; }
        public bool scaling_button { get; set; }
        public bool speed { get; set; }
        public string title { get; set; }
        public bool volume { get; set; }
        public bool transparent { get; set; }
        public object allow_title_override { get; set; }
        public object outro_background_id { get; set; }
        public int outro_version { get; set; }
        public object email_capture_timecode { get; set; }
        public bool email_capture_during_playback { get; set; }
        public StreamClips stream_clips { get; set; }
        public bool? custom_logo_use_link { get; set; }
        public bool? color_original { get; set; }
    }

    public class Videos3
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Connections3
    {
        public Videos3 videos { get; set; }
    }

    public class Metadata3
    {
        public Connections3 connections { get; set; }
    }

    public class Size3
    {
        public int width { get; set; }
        public int height { get; set; }
        public string link { get; set; }
    }

    public class Pictures5
    {
        public string uri { get; set; }
        public bool active { get; set; }
        public string type { get; set; }
        public List<Size3> sizes { get; set; }
        public string resource_key { get; set; }
    }

    public class Website
    {
        public string name { get; set; }
        public string link { get; set; }
        public string description { get; set; }
    }

    public class Activities2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
    }

    public class Albums2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Appearances2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Channels2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Feed2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
    }

    public class Followers2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Following2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Groups2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Likes3
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class ModeratedChannels2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Portfolios2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Videos4
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Shared2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Pictures6
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public int total { get; set; }
    }

    public class Connections4
    {
        public Activities2 activities { get; set; }
        public Albums2 albums { get; set; }
        public Appearances2 appearances { get; set; }
        public Channels2 channels { get; set; }
        public Feed2 feed { get; set; }
        public Followers2 followers { get; set; }
        public Following2 following { get; set; }
        public Groups2 groups { get; set; }
        public Likes3 likes { get; set; }
        public ModeratedChannels2 moderated_channels { get; set; }
        public Portfolios2 portfolios { get; set; }
        public Videos4 videos { get; set; }
        public Shared2 shared { get; set; }
        public Pictures6 pictures { get; set; }
    }

    public class Follow2
    {
        public bool added { get; set; }
        public object added_time { get; set; }
        public string uri { get; set; }
    }

    public class Block2
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public bool added { get; set; }
        public object added_time { get; set; }
    }

    public class Report3
    {
        public string uri { get; set; }
        public List<string> options { get; set; }
        public List<string> reason { get; set; }
    }

    public class Interactions3
    {
        public Follow2 follow { get; set; }
        public Block2 block { get; set; }
        public Report3 report { get; set; }
    }

    public class Metadata4
    {
        public Connections4 connections { get; set; }
        public Interactions3 interactions { get; set; }
    }

    public class Videos5
    {
        public object privacy { get; set; }
    }

    public class Preferences2
    {
        public Videos5 videos { get; set; }
    }

    public class User2
    {
        public string uri { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string location { get; set; }
        public string bio { get; set; }
        public DateTime created_time { get; set; }
        public Pictures5 pictures { get; set; }
        public List<Website> websites { get; set; }
        public Metadata4 metadata { get; set; }
        public string resource_key { get; set; }
        public string account { get; set; }
        public Preferences2 preferences { get; set; }
    }

    public class EmbedPresets
    {
        public string uri { get; set; }
        public string name { get; set; }
        public Settings settings { get; set; }
        public Metadata3 metadata { get; set; }
        public User2 user { get; set; }
    }

    public class Datum
    {
        public string uri { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public int duration { get; set; }
        public int width { get; set; }
        public string language { get; set; }
        public int height { get; set; }
        public Embed embed { get; set; }
        public DateTime created_time { get; set; }
        public DateTime modified_time { get; set; }
        public DateTime release_time { get; set; }
        public List<string> content_rating { get; set; }
        public string license { get; set; }
        public Privacy privacy { get; set; }
        public Pictures pictures { get; set; }
        public List<object> tags { get; set; }
        public Stats stats { get; set; }
        public Metadata metadata { get; set; }
        public User user { get; set; }
        public App app { get; set; }
        public string status { get; set; }
        public string resource_key { get; set; }
        public Upload upload { get; set; }
        public Transcode transcode { get; set; }
        public string review_link { get; set; }
        public EmbedPresets embed_presets { get; set; }
    }

    public class QueryRootObject
    {
        public int total { get; set; }
        public int page { get; set; }
        public int per_page { get; set; }
        public Paging paging { get; set; }
        public List<Datum> data { get; set; }
    }

    public class Download
    {
        public string quality { get; set; }
        public string type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public DateTime expires { get; set; }
        public string link { get; set; }
        public DateTime created_time { get; set; }
        public double fps { get; set; }
        public int size { get; set; }
        public string md5 { get; set; }
    }

    public class VideoRootObject
    {
        public string uri { get; set; }
        public string name { get; set; }
        public object description { get; set; }
        public string link { get; set; }
        public int duration { get; set; }
        public int width { get; set; }
        public object language { get; set; }
        public int height { get; set; }
        public Embed embed { get; set; }
        public DateTime created_time { get; set; }
        public DateTime modified_time { get; set; }
        public DateTime release_time { get; set; }
        public List<string> content_rating { get; set; }
        public object license { get; set; }
        public Privacy privacy { get; set; }
        public Pictures pictures { get; set; }
        public List<object> tags { get; set; }
        public Stats stats { get; set; }
        public Metadata metadata { get; set; }
        public User user { get; set; }
        public DateTime last_user_action_event_date { get; set; }
        public List<File> files { get; set; }
        public List<Download> download { get; set; }
        public App app { get; set; }
        public string status { get; set; }
        public string resource_key { get; set; }
        public Upload upload { get; set; }
        public Transcode transcode { get; set; }
        public string review_link { get; set; }
        public EmbedPresets embed_presets { get; set; }
    }

    public class File
    {
        public string quality { get; set; }
        public string type { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string link { get; set; }
        public DateTime created_time { get; set; }
        public double fps { get; set; }
        public int size { get; set; }
        public string md5 { get; set; }
        public string link_secure { get; set; }
    }
}
