using UnityEngine;
static class Config
{
    public static float probTweetReadBase = 0.1f;
    public static float probTweetReadMax = 0.99f;
    public static float ProbTweetReadWithFavourability(byte favourability)
    {
        return Mathf.Clamp(probTweetReadBase + favourability, 0, probTweetReadMax);
    }
}
