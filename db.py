import os
from dotenv import load_dotenv
from sqlalchemy import create_engine
from sqlalchemy.orm import sessionmaker
from supabase import create_client
from model.model import Base

from supabase import create_client, Client
from supabase.client import ClientOptions

load_dotenv()

db_env = os.getenv('DATABASE_URL')
engine = create_engine(db_env)

SessionLocal = sessionmaker(autocommit=False, autoflush=False, bind=engine)

url: str = os.getenv("SUPABASE_URL")
key: str = os.getenv("SUPABASE_KEY")

supabase: Client = create_client(url, key,
  options=ClientOptions(
    postgrest_client_timeout=10,
    storage_client_timeout=10,
    schema="public",
  ))

Base.metadata.create_all(bind=engine)