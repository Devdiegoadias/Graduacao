using AzureTablesDemoApplication.Entities;
using AzureTablesDemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using Azure.Data.Tables;

namespace AzureTablesDemoApplication.Services
{
    public class TablesService
    {
        private TableClient _tableClient;
           

        public TablesService( TableClient tableclient)
        {
            _tableClient = tableclient;
        }


        public string[] EXCLUDE_TABLE_ENTITY_KEYS = { "PartitionKey", "RowKey", "odata.etag", "Timestamp" };



        public IEnumerable<WeatherDataModel> GetAllRows()
        {
            Pageable<TableEntity> entities = _tableClient.Query<TableEntity>();

            return entities.Select(e => MapTableEntityToWeatherDataModel(e));            
        }


        public IEnumerable<WeatherDataModel> GetFilteredRows(FilterResultsInputModel inputModel)
        {
            return null;
        }

        public WeatherDataModel MapTableEntityToWeatherDataModel( TableEntity e)
        {
            WeatherDataModel observation = new WeatherDataModel();

            observation.StationName = e.PartitionKey;
            observation.ObservationDate = e.RowKey;
            observation.Timestamp = e.Timestamp;
            observation.Etag = e.ETag.ToString();

            var measurements = e.Keys.Where(key => !EXCLUDE_TABLE_ENTITY_KEYS.Contains(key));

            foreach(var key in measurements)
            {
                observation[key] = e[key];
            }

            return observation;

        }




        public void InsertTableEntity(WeatherInputModel model)
        {
            TableEntity entity = new TableEntity();
            entity.PartitionKey = model.StationName;
            entity.RowKey = $"{ model.ObservationDate}{ model.ObservationTime}";
            
            entity["Temperature"] = model.Temperature;
            entity["Humidity"] = model.Humidity;
            entity["Barometer"] = model.Barometer;
            entity["WindDirection"] = model.WindDirection;
            entity["WindSpeed"] = model.WindSpeed;
            entity["Precipitation"] = model.Precipitation;

            _tableClient.AddEntity(entity);
        }


        public void UpsertTableEntity(WeatherInputModel model)
        {

        }


        public void InsertExpandableData(ExpandableWeatherObject weatherObject)
        {

        }


        public void UpsertExpandableData(ExpandableWeatherObject weatherObject)
        {

        }

        public void RemoveEntity(string partitionKey, string rowKey)
        {

        }


        public void UpdateEntity(UpdateWeatherObject weatherObject)
        {

        }

    }
}
